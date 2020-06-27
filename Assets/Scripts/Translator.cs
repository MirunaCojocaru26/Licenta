using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

public class Translator : MonoBehaviour
{
    public bool debug;
    string targetLang;
    string sourceLang;

    public static Translator Create(string sourceLang, string targetLand)
    {
        GameObject entity = new GameObject("Translation");
        entity.hideFlags = HideFlags.HideAndDontSave;
        DontDestroyOnLoad(entity);

        Translator instance = entity.AddComponent<Translator>();
        instance.targetLang = targetLand;
        instance.sourceLang = sourceLang;
        return instance;
    }

    public void Run(string text, Action<TranslatedText[]> result)
    { 
        StartCoroutine(TranslateAsync(text, result));
    }

    IEnumerator TranslateAsync(string text, Action<TranslatedText[]> result)
    {
        string sourceLang = "auto";
        string url = "https://translate.googleapis.com/translate_a/single?client=gtx&sl=" + sourceLang + "&tl=" + targetLang + "&dt=t&q=" + WWW.EscapeURL(text);
        Dictionary<string, string> headers = new Dictionary<string, string>();
        headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " + "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
        WWW req = new WWW(url, null, headers);

        yield return req;

        if (string.IsNullOrEmpty(req.error))
        {
            var json = JArray.Parse(req.text);
            var results = new List<TranslatedText>();

            foreach (var v in (JArray)(json[0]))
            {
                results.Add(new TranslatedText(
                        (string)(v[1]),
                        (string)(v[0])
                    )
                );
            }
            result(results.ToArray());
        }
        else
        {
            Debug.Log(req.error);
            result(null);
        }
    }
}
