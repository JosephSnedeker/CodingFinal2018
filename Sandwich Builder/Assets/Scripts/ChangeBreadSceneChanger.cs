﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeBreadSceneChanger : MonoBehaviour {

	// Use this for initialization
	public void onClick()
    {
        SceneManager.LoadScene("BreadSelect");
    }
}