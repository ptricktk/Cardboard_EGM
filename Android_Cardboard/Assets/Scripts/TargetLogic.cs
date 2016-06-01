using UnityEngine;
using System.Collections;

public class TargetLogic : MonoBehaviour {

    private int TargetValue;
    private GameManagement gm;
    private AudioSource quack;

    // Use this for initialization
	void Start () {
        TargetValue = 1;
        gm = GameManagement.instance;
        quack = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void HitRecieved()
    {
        quack.Play();
        transform.position = gm.SpawnLocations[Mathf.RoundToInt(Random.Range(0, gm.SpawnLocations.Length -1))].transform.position; 
        gm.updateScore(TargetValue);
    }

    
}
