using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugScript : MonoBehaviour {

	public GameObject Floor;
	public GameObject Camera;


	// Use this for initialization
	void Start () {

		Debug.Log ("startfloor:" + Floor.gameObject.transform.position);
		Debug.Log ("startcamera:" + Camera.gameObject.transform.position);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.Log ("floor:" + Floor.gameObject.transform.position);
		Debug.Log ("camera:" + Camera.gameObject.transform.position);
	}
}
