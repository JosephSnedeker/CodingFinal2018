using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SelectingVeggies : MonoBehaviour {

    [SerializeField]
    Veggies veggie = new Veggies();
	// Use this for initialization
	void Start () {
       

	}
	
	// Update is called once per frame
	void Update () {
        if (GameManager.Instance.selectedSandwich.veggies.Contains(veggie))
        {
            Color thisButton = GetComponent<Button>().image.color;
            thisButton = Color.HSVToRGB(0,0,0,true);
        }
	}
}
