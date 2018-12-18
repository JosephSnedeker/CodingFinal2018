using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class veggieText : MonoBehaviour {
    [SerializeField]
    int instance;
	// Use this for initialization
	void Start () {
        if (instance < GameManager.Instance.selectedSandwich.veggies.Count)
        {
            GetComponent<Text>().text = GameManager.Instance.selectedSandwich.veggies[instance].ToString();
        }
        else
            GetComponent<Text>().text = "";
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
