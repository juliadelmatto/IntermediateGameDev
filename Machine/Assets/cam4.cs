using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam4 : MonoBehaviour {
	public Camera Camera4;

	public Camera Camera5;
	// Use this for initialization
	void Start () {
		Camera5.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "player3") {
			Camera4.gameObject.SetActive (false);
			Camera5.gameObject.SetActive (true);
			Debug.Log ("hello");
		}
	}
}
