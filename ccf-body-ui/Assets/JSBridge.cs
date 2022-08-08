using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JSBridge : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textBox;

    public void SetText(string str)
    {
        textBox.text = str;
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SetText("Hello!");
        }
    }
}
