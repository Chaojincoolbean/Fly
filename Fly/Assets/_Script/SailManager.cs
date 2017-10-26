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

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.timeSinceLevelLoad > SailStartTime-10f)
        {
            BackgroundMusic.SetActive(true);
        }

        if (Time.timeSinceLevelLoad > SailStartTime) {
			Boat.SetActive (true);
            Sail();
  
        }

        if (Time.timeSinceLevelLoad > SailStartTime + 60f)
        {
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
