using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatMovement : MonoBehaviour {

	public GameObject Player;
	public float StartTime;
	public float FloatSpeed;


	// Use this for initialization
	void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > StartTime) {

			Player.transform.position = new Vector3 (Player.transform.position.x, Player.transform.position.y + FloatSpeed, Player.transform.position.z);


		}
		
	}
}
