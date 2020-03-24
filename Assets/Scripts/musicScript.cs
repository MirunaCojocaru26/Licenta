using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class musicScript : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown dd;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MyExposedParam", (-1 + volume) * 80);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
        dd.value = qualityIndex;
    }
}
