using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSandwich : MonoBehaviour {
    
    Sandwich sandwich = new Sandwich();

    public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");
        Sandwich sandwichChosen = sandwich;
    }
}
