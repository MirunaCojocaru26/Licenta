using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text textt;
    public string text;
    TextScript(string comp)
    {
        this.text = comp;
    }

    public void OnChange()
    {
        textt.text = text;
    }
}
