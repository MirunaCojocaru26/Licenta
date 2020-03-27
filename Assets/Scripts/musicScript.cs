using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MusicScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volm = 1;
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
            }
            volm = data.volume;
            mSlider.value = data.volume;
        }
    }

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MyExposedParam", Mathf.Log10(volume) * 20);
        volm = volume;
        SaveSystem.SaveSettings(this);
    }
}
