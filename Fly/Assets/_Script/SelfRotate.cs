﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRotate : MonoBehaviour {

	public float LoadTime;
	public float n;

	// Use this for initialization
	void Start () {

		LoadTime = 0;
	}
	
	// Update is called once per frame
	void Update () {

		LoadTime = LoadTime + Time.deltaTime;

		transform.Rotate (Vector3.up * n * Time.deltaTime);

		n = n - LoadTime * 0.00005f;

		Debug.Log (n);
		
	}
}
