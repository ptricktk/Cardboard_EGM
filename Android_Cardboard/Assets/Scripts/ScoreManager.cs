using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    Text text;
    
    // Use this for initialization
	void Awake () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (GameManagement.instance.GameState != "started")
            text.enabled = true;
        else
            text.enabled = false;

        text.text = "Je Score is " + GameManagement.instance.Score;
    }
}
