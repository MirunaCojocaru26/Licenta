using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    public Text textt;
    public Image panel;

    public void OnAppear(string aux)
    {
        textt.text = aux;
        Color color = new Color(0.69F, 0.62F, 0.53F, 0.7F);
        panel.color = color;
    }

    public void OnDisappear()
    {
        textt.text = " ";
        Color color = new Color(0.2F, 0.3F, 0.4F, 0F);
        panel.color = color;
    }
}
