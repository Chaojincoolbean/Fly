using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour {

	public bool DebugCamera;
	public bool DebugLeftController;
	public bool DebugRightController;
	public GameObject Camera;
	public GameObject LeftController;
	public GameObject RightController;


	// Use this for initialization
	void Start () {

		InputDebug ();

		
	}
	
	// Update is called once per frame
	void Update () {

		InputDebug ();

	}

	void InputDebug(){
	
		if (DebugCamera == true) {
			Debug.Log ("startCamera:" + Camera.gameObject.transform.position);
		}

		if (DebugLeftController == true) {
			Debug.Log ("startLeftController:" + LeftController.gameObject.transform.position);
		}

		if (DebugRightController == true) {

			Debug.Log ("startRightController:" + RightController.gameObject.transform.position);
		}
	}
}
