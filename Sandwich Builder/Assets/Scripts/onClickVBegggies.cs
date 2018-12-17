using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class onClickVBegggies : MonoBehaviour
{

    [SerializeField]
    Veggies veggie;

    public void onClick()
    {
        if (!GameManager.Instance.selectedSandwich.veggies.Contains(veggie))
        {
            GameManager.Instance.selectedSandwich.veggies.Add(veggie);
        }
        else if (GameManager.Instance.selectedSandwich.veggies.Contains(veggie))
        {
            GameManager.Instance.selectedSandwich.veggies.Remove(veggie);
        }
        
    }
}
