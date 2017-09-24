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
	public float StandandY = 1.4f; //Where the player's arm is on Y position when they raise

	// Use this for initialization
	void Start () {

		LLT.position = LeftController.transform.position;
		LRT.position = RightController.transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {

		CLT.position = LeftController.transform.position;
		CRT.position = RightController.transform.position;

		if ((CLT.position.y < StandandY) &(LLT.position.y > StandandY)
			&(CRT.position.y < StandandY) & (LRT.position.y > StandandY)) {

			Camera.gameObject.transform.position = new Vector3 (Camera.gameObject.transform.position.x, 
				Camera.gameObject.transform.position.y + 1f, 
				Camera.gameObject.transform.position.z);
		}

		LLT.position = CLT.position;
		LRT.position = CRT.position;
		
	}
}
