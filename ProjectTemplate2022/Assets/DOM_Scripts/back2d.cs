using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class back2d : MonoBehaviour
{
    void Start()
    {
        if (VRLoader.mode2D == "off")
        {
            VRLoader.modeVR = "off";
            VRLoader.mode2D = "on";
            StartCoroutine(DeactivatorVR("none"));
        }
        print($"VR:{VRLoader.modeVR},2D:{VRLoader.mode2D}");
    }

    public IEnumerator DeactivatorVR(string NOVR)
    {
        UnityEngine.XR.XRSettings.LoadDeviceByName(NOVR);
        yield return null;
        UnityEngine.XR.XRSettings.enabled = false;
    }
}
