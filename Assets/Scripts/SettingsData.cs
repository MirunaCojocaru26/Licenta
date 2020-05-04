using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class SettingsData
{
    public float volume;
    public int quality;

    public SettingsData (SettingsScript settings)
    {
        volume = settings.volm;
        quality = settings.quality;
    }
}
