using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public GameObject CameraRig;
	public GameObject LeftController;
	public GameObject RightController;
	public Transform LLT; //LLT = LastLeftContollerTransform
	public Transform LRT; //LRT = LastRightContollerTransform
	public Transform CLT; //CLT = CurrentLeftControllerTransform
	public Transform CRT; //CRT = CurrentRightControllerTransform
	//public Transform 

	// Use this for initialization
	void Start () {

		LLT.position = LeftController.transform.position;
		LRT.position = RightController.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		CLT.position = LeftController.transform.position;
		CRT.position = RightController.transform.position;






		
	}
}
