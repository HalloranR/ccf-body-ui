using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public static class WebGLPluginJS
{
    [DllImport("__Internal")]
    public static extern void SendMessageToPage(string text);
}
