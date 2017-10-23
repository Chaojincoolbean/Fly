using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailManager : MonoBehaviour {

	public GameObject Boat;
	public GameObject Player;
	public float SailStartTime;
	public float SailSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > SailStartTime) {
			Boat.SetActive (true);
            Sail();
		}
		
	}

	public void Sail(){

		Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - SailSpeed);
		Boat.transform.position = new Vector3(Boat.transform.position.x, Boat.transform.position.y, Boat.transform.position.z - SailSpeed);
	}
}
