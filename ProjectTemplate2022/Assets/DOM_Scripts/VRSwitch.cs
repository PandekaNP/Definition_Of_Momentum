using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class VRSwitch : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        if (VRLoader.modeVR == "off")
        {
            VRLoader.modeVR = "on";
            VRLoader.mode2D = "off";
            StartCoroutine(ActivatorVR("Cardboard"));
        }
        print($"VR:{VRLoader.modeVR},2D:{VRLoader.mode2D}");
    }

    public IEnumerator ActivatorVR(string YESVR)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(YESVR);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = true;
    }
}
