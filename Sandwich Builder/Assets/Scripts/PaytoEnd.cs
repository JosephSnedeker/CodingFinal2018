using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PaytoEnd : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("The End Game");
    }
}
