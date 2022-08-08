using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputManager : MonoBehaviour
{
    //this script is the bridge, takes user input to trigger funcs

    [SerializeField] private CameraManager cameraScript;

    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            cameraScript.SwapToOrbit();
        }
        if (Input.GetKeyDown("h"))
        {
            cameraScript.SwapToStatic();
        }
    }
}
