using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenCariere()
    {
        Application.OpenURL("http://cariere.as-mi.ro");
    }
    public void OpenSiteFaculty()
    {
        Application.OpenURL("http://fmi.unibuc.ro/en/");
    }
}
