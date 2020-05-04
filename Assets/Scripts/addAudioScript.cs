using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class addAudioScript : MonoBehaviour
{

    private static addAudioScript instance = null;
    public GameObject go;

    void Start()
    {
        go = GameObject.FindGameObjectWithTag("music");
        SettingsData data = SaveSystem.LoadSettings();
        go.GetComponent<AudioSource>().volume = data.volume;
        QualitySettings.SetQualityLevel(data.quality*2);
    }

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
