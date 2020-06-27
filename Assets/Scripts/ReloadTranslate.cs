using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ReloadTranslate : MonoBehaviour
{
    private GameObject[] texts;
    string response;
    public int nrTexts;
    void Start()
    {
        string toTranslate = "";
        var renderer = GetComponentsInChildren<Text>().ToArray();
        foreach (var t in renderer)
        {
            if (t.text == "")
            {
                toTranslate += "*.";
            }
            else
            {
                toTranslate += t.text + ".";
            }
        }
        translate(toTranslate, renderer);
    }

    public void translate(string myText, Text[] texts)
    {
        Language lang = new Language();
        string first = lang.prefLang("Auto");
        string lang_name = PlayerPrefs.GetString("language");
        string second = lang.prefLang(lang_name);
        Translator translator = Translator.Create(first, second);
        int i = 0;
        translator.Run(myText, results => {
            foreach (var result in results)
            {
                response = response + result.translated;
            }
            string[] textTranslate = response.Split('.');
            for (i = 0; i < texts.Length; i++)
            {
                if (textTranslate[i] != "*")
                    texts[i].text = textTranslate[i];
            }
        });

    }
}