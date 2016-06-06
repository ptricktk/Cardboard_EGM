using UnityEngine;
using System.Collections;

public class VRmodus : MonoBehaviour {

    public void WisselVRmodus()
    {
        GvrViewer.Instance.VRModeEnabled = !GvrViewer.Instance.VRModeEnabled;
        
        GameManagement.instance.StartGame();
    }
}
