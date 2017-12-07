using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SailManager : MonoBehaviour {

	public GameObject Boat;
	public GameObject Player;
	public float SailStartTime;
	public float SailSpeed;
    public GameObject Memories;
    public GameObject BackgroundMusic;
    public GameObject End;
    public float Loadtime;

	// Use this for initialization
	void Start () {

        Player.transform.position = new Vector3(0f, 0f, 0f);
        Loadtime = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {

        Loadtime = Loadtime + Time.deltaTime;

        if (Loadtime > SailStartTime-10f)
        {
            BackgroundMusic.SetActive(true);
        }

        if (Loadtime > SailStartTime) {

			Boat.SetActive (true);
            Sail();
  
        }

        if (Loadtime > SailStartTime + 60f)
        {
            //BackgroundMusic.SetActive(true);
            Memories.SetActive(true);
        }

        if(Player.transform.position.z < -135f)
        {
            End.SetActive(true);
        }

    }

	public void Sail(){

		Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z - SailSpeed);
		Boat.transform.position = new Vector3(Boat.transform.position.x, Boat.transform.position.y, Boat.transform.position.z - SailSpeed);
	}
}
