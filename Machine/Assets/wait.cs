﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		GetComponent<Rigidbody>().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			GetComponent<Rigidbody>().isKinematic = false;
		}
		
	}
}
