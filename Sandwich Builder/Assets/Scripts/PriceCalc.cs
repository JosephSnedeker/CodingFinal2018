using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PriceCalc : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float price = GameManager.Instance.selectedSandwich.price * 1.0513f;
        GetComponent<Text>().text = price.ToString("#.##");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
