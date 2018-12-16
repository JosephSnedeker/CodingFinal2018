using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneBread : MonoBehaviour {
    [SerializeField]
    Bread bread = new Bread();

    public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");
    }
}
