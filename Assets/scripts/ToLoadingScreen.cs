﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ToLoadingScreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ProgressToLoad()
    {
        SceneManager.LoadScene("loading_screen");
    }
}
