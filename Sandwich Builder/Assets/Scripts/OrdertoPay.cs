using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OrdertoPay : MonoBehaviour {

    public void onClick()
    {
        SceneManager.LoadScene("Pay");
    }
}
