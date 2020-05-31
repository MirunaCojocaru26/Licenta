using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jsonController : MonoBehaviour
{
    public string jsonURL;
    public jsonDataClass jsnData;
    void Start()
    {
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        WWW _www = new WWW(jsonURL);
        yield return _www;
        if(_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Oops, something went wrong");
        }
    }

    private void processJsonData(string _url)
    {
        jsnData = JsonUtility.FromJson<jsonDataClass>(_url);
    }
}
