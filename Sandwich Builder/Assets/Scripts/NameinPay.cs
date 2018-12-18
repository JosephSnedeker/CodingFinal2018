using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameinPay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string name = GameManager.Instance.selectedSandwich.name;
        GetComponent<Text>().text = name;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
