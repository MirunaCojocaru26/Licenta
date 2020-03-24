using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WindowApplication
{
    public class chanceScene : MonoBehaviour
    {
        public void NextScene(string sceneindex)
        {
            Debug.Log("sceneName to load: " + sceneindex);
            SceneManager.LoadScene(sceneindex);
        }
    }
}