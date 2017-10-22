using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatMovement : MonoBehaviour {

	public GameObject Player;
	public float StartTime;
	public float FloatSpeed;
//	public float FloatSpeed1;
//    public float FloatSpeed2;
//    public float FloatSpeed3;
//    public float FloatSpeed4;
//    public float SpeedupPoint1;
//    public float SpeedupPoint2;
//    public float SpeedupPoint3;
//    public float FloatEndPositionX;
//    public float FloatEndPositionY;
    public float MoveForwardStopTime;
    public bool FloatForwardEnd = false;
    private float FloatUpStopTime = 0;

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time > StartTime)
        {
            FloatUp();
        }      

	}

    void FloatUp()
    {

		FloatSpeed = Time.time;
        Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + FloatSpeed, Player.transform.position.z);

//            if (Player.transform.position.y > SpeedupPoint1)
//            {
//                Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + FloatSpeed2, Player.transform.position.z);
//            }
//
//            if (Player.transform.position.y > SpeedupPoint2)
//            {
//                Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + FloatSpeed3, Player.transform.position.z);
//            }
//
//            if (Player.transform.position.y > SpeedupPoint3)
//            {
//                Player.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + FloatSpeed4, Player.transform.position.z);
//            }
//
//            if (Player.transform.position.y > FloatEndPositionY)
//            {
//                SceneManager.LoadScene(2);
//                //FloatUpEnd = true;
//                //FloatUpStopTime = Time.time;
//            }
    }

//    void FloatForward()
//    {
//
//        Player.transform.position = new Vector3(Player.transform.position.x + FloatSpeed1, Player.transform.position.y, Player.transform.position.z);
//
//        if (Player.transform.position.x > FloatEndPositionX)
//        {
//           FloatForwardEnd = true;
//           //FloatUpStopTime = Time.time;
//        }
//
//    }
}
