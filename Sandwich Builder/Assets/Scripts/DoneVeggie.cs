using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoneVeggie : MonoBehaviour {

	public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");
    }
}
