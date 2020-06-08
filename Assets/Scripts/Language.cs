using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language : MonoBehaviour
{
    public string chooseLang;
    public string prefLang(string nameLang)
    {
        switch (nameLang)
        {
            case "English":
                chooseLang = "en";
                break;
            case "German":
                chooseLang = "de";
                break;
            case "Portuguese":
                chooseLang = "pt";
                break;
            case "Russian":
                chooseLang = "ru";
                break;
            case "Spanish":
                chooseLang = "es";
                break;
            case "Romanian":
                chooseLang = "ro";
                break;
            default:
                chooseLang = "auto";
                break;
        }
        return chooseLang;
    }

}
