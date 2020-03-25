using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volm = 1;
    public int quality = 3;
    public Slider mSlider;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MyExposedParam", (-1 + volume) * 80);
        volm = volume;
        SaveSystem.SaveSettings(this);
       // LoadAll();
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        quality = qualityIndex;
        SaveSystem.SaveSettings(this);
        //LoadAll();
    }
    public void LoadAll()
    {
        //aici e problema
        if (GameObject.FindGameObjectWithTag("mycanvas"))
        {
            mSlider = (Slider)FindObjectOfType(typeof(Slider));
        }
        SettingsData data = SaveSystem.LoadSettings();
        volm = data.volume;
        quality = data.qualityindex;
        Debug.Log("before = " + mSlider.value);
        mSlider.value = data.volume;
        Debug.Log("after = " + mSlider.value);
        //si mai trebe sa si apelez cumva functia asta
    }
}
