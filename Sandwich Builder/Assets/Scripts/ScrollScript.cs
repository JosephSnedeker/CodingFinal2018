using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 placeholder = transform.position;
        placeholder.y -= Input.GetAxis("Mouse ScrollWheel") * 8;
        transform.position = placeholder;

        
	}
}
