using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSandwich : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");
    }
}
