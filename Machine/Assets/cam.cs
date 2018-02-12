using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cam : MonoBehaviour {

	public Camera Camera1;

	public Camera Camera2;





	// Use this for initialization
	void Start () {
		Camera1.gameObject.SetActive(true);
		Camera2.gameObject.SetActive(false);


	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown("a"))
//		{
//			Camera1.gameObject.SetActive(false);
//			Camera2.gameObject.SetActive(true);
//
//		}
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "player2") {
			Camera1.gameObject.SetActive (false);
			Camera2.gameObject.SetActive (true);

		}


	}
}
