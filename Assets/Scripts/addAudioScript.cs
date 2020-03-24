using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addAudioScript : MonoBehaviour
{

    private static addAudioScript instance = null;
    public static addAudioScript Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if (instance != null & instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
