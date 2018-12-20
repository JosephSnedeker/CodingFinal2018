using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaloriesinPay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string calories = GameManager.Instance.selectedSandwich.calorieCount;
        GetComponent<Text>().text = calories;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
