using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSauceSeneChanger : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("SauceSelect");
    }
}
