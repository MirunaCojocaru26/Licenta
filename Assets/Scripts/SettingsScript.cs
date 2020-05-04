using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volm = 1;
    public int quality = 2;
    public Slider mSlider;
    public Dropdown dropDown;

    void Awake()
    {
        SettingsData data = SaveSystem.LoadSettings();
        if (data != null)
        {
            if (GameObject.FindGameObjectWithTag("mycanvas"))
            {
                mSlider = (Slider)FindObjectOfType(typeof(Slider));
                dropDown = (Dropdown)FindObjectOfType(typeof(Dropdown));
            }
            volm = data.volume;
            mSlider.value = data.volume;
            quality = data.quality;
            dropDown.value = data.quality;
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MyExposedParam", Mathf.Log10(volume) * 20);
        volm = volume;
        SaveSystem.SaveSettings(this);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex*2);
        quality = qualityIndex;
        SaveSystem.SaveSettings(this);
    }
}
