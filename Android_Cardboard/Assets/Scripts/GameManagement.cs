using UnityEngine;
using System.Collections;

public class GameManagement : MonoBehaviour {

    public static GameManagement instance = null;

    public GameObject[] SpawnLocations;
    public int Score;


	// Use this for initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        Score = 0;

        SpawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoints");
	}
	

    public void updateScore(int ScoreToAdd)
    {
        Score += ScoreToAdd;
    }

}
