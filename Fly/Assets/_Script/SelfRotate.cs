using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour {

	public float n;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Rotate (Vector3.up * n * Time.deltaTime);

		n = n - Time.time * 0.00005f;

		Debug.Log (n);
		
	}
}
