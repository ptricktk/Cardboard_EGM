using UnityEngine;
using System.Collections;

public class GameManagement : MonoBehaviour {

    public static GameManagement instance = null;

    public GameObject[] SpawnLocations;
    public int Score;
    public string GameState = "ended";


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


    void Start ()
    {
        StartGame();
    }	

    public void StartGame()
    {
        Score = 0;
        GameState = "started";
        Invoke("EndTimer", 65f);
    }

    private void EndTimer()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
        GameState = "ended";
    }

    public void updateScore(int ScoreToAdd)
    {
        Score += ScoreToAdd;
    }

}
