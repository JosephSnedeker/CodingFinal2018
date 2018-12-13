using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifySandwich : MonoBehaviour {
    [SerializeField]
    Sandwich sandwichToModify;
	// Use this for initialization
	void Start () {
        
        sandwichToModify = GameManager.Instance.selectedSandwich;
        Debug.Log(sandwichToModify.bread);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
