using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void Open()
    {
        Application.OpenURL("http://cariere.as-mi.ro");
    }
}
