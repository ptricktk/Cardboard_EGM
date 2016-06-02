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
        InvokeRepeating("SwitchToRandomSpawnpoint", 10f, 3f);
	}
	

    public void HitRecieved()
    {
        if (GameManagement.instance.GameState != "ended")
        { 
            quack.Play();
            transform.position = gm.SpawnLocations[Mathf.RoundToInt(Random.Range(0, gm.SpawnLocations.Length -1))].transform.position; 
            gm.updateScore(TargetValue);
        }
    }

    private void SwitchToRandomSpawnpoint()
    {
        transform.position = gm.SpawnLocations[Mathf.RoundToInt(Random.Range(0, gm.SpawnLocations.Length - 1))].transform.position;
    }
    
}
