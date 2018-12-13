using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifySandwich : MonoBehaviour {
    [SerializeField]
    Sandwich sandwichToModify;
	// Use this for initialization
	void Start () {
        
        sandwichToModify = GameManager.Instance.selectedSandwich;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
