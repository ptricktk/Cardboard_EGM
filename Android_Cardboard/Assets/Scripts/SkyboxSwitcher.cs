using UnityEngine;
using System.Collections;

public class SkyboxSwitcher : MonoBehaviour {

    int i = 0;

    public Material[] skyboxes;

	// Use this for initialization
	void Start () {
        InvokeRepeating("switchSkybox", 0f, 10f);
	}
	
	void switchSkybox()
    {
        RenderSettings.skybox = skyboxes[i];
        i++;
        if (i > skyboxes.Length - 1)
            i = 0;

    }
}
