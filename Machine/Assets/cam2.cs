using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam2 : MonoBehaviour {


	public Camera Camera2;

	public Camera Camera3;

	// Use this for initialization
	void Start () {
		Camera3.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "player") {
			Camera2.gameObject.SetActive (false);
			Camera3.gameObject.SetActive (true);
			Debug.Log ("hello");
		}
}
}

