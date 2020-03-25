using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class SettingsData
{
    public float volume;
    public int qualityindex;

    public SettingsData (MusicScript settings)
    {
        volume = settings.volm;
        qualityindex = settings.quality;
    }
}
