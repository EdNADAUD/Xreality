using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Autofocus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    // Update is called once per frame
    void Update()
    {
       // if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
     //     CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
    }
}
