using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectingVeggies : MonoBehaviour {

    [SerializeField]
    Veggies veggie;
	// Use this for initialization
	void Start () {

       
    }
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.selectedSandwich.veggies.Contains(veggie))
        {

            GetComponent<Button>().image.color = new Color(1, 1, 1, 1);
        }
    }

}
