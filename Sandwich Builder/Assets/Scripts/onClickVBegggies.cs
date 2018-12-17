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
        GameManager.Instance.selectedSandwich.veggies.Add(veggie);
    }
}
