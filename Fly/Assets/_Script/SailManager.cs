using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailManager : MonoBehaviour {

	public GameObject Boat;
	public GameObject Player;
	public float SailStartTime;
	public float SailSpeed;
	public float DrowingSpeed;
    public GameObject BackgroundMusic;
    public float Loadtime;
	public float Drown;


	// Use this for initialization
	void Start () {

        Player.transform.position = new Vector3(0f, 0f, 0f);
        Loadtime = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {

        Loadtime = Loadtime + Time.deltaTime;

        if (Loadtime > SailStartTime) {

			Boat.SetActive (true);
            Sail();
  
        }

		if(Player.transform.position.y < Drown)
        {
            //End.SetActive(true);
        }

    }

	public void Sail(){

		Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - DrowingSpeed, Player.transform.position.z + SailSpeed);
		Boat.transform.position = new Vector3(Boat.transform.position.x, Boat.transform.position.y - DrowingSpeed, Boat.transform.position.z + SailSpeed);

	}
}
