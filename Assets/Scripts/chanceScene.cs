﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class chanceScene : MonoBehaviour
{
    public void NextScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}