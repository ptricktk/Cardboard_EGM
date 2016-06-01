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
        text.text =  "Je Score is " + GameManagement.instance.Score;
	}
}
