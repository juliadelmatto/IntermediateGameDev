using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam3 : MonoBehaviour {
	public Camera Camera3;

	public Camera Camera4;
	// Use this for initialization
	void Start () {
		Camera4.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "player") {
			Camera3.gameObject.SetActive (false);
			Camera4.gameObject.SetActive (true);
			Debug.Log ("hello");
		}
	}
}
