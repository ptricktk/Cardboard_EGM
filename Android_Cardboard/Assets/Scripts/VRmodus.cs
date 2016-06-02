using UnityEngine;
using System.Collections;

public class VRmodus : MonoBehaviour {

    public void WisselVRmodus()
    {
        Cardboard.SDK.VRModeEnabled = !Cardboard.SDK.VRModeEnabled;
        
        GameManagement.instance.StartGame();
    }
}
