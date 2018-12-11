using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSandwich : MonoBehaviour {
    [SerializeField]
    Sandwich sandwich = new Sandwich();

    public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");
        Sandwich sandwichChosen = sandwich;
    }
}
