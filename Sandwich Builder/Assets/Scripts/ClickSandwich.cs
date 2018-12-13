using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickSandwich : MonoBehaviour {
    [SerializeField]
    static Sandwich sandwich = new Sandwich();
    public Sandwich sandwichChosen;

    public void onClick()
    {
        SceneManager.LoadScene("ModifySandwich");        
        sandwichChosen = sandwich;
        Debug.Log("sandwich chosen is " + sandwichChosen.bread);
    }
}
