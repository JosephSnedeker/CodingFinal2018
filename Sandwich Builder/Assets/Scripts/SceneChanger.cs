﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("SelectSandwich");
        }
        if (Input.anyKey)
        {
            SceneManager.LoadScene("SelectSandwich");
        }


    }
}
