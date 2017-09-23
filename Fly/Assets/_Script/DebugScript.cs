using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour {

	public bool IsDebug;
	public GameObject Camera;
	public GameObject LeftController;
	public GameObject RightController;


	// Use this for initialization
	void Start () {

		if (IsDebug == true) {

			Debug.Log ("startCamera:" + Camera.gameObject.transform.position);
			Debug.Log ("startLeftController:" + LeftController.gameObject.transform.position);
			Debug.Log ("startRightController:" + RightController.gameObject.transform.position);
		}

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (IsDebug == true) {

			Debug.Log ("camera:" + Camera.gameObject.transform.position);
			Debug.Log ("LeftController:" + LeftController.gameObject.transform.position);
			Debug.Log ("RightController:" + RightController.gameObject.transform.position);
		}

	}
}
