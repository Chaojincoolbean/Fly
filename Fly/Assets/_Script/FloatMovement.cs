using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatMovement : MonoBehaviour {

	public GameObject Player;
    public GameObject BackgroundAudio;
    public float LoadTime;
	public float StartTime;
	public float FloatSpeed;
    public float Acceleration;
    public float MaxSpeed;
//	public float FloatSpeed1;
//    public float FloatSpeed2;
//    public float FloatSpeed3;
//    public float FloatSpeed4;
    public float AccelerationPoint;
    public float AccelerationPoint2;
    public float AccelerationPoint3;
//    public float FloatEndPositionX;
    public float FloatEndPositionY;
    public float MoveForwardStopTime;
    public bool FloatForwardEnd = false;
    public bool MusicPlay = true;
    private float FloatUpStopTime = 0;
    public AudioSource AS;
    public AudioSource BA;
    public GameObject Moment;
    public GameObject Sail;
    public Camera PlayerCamera;
    public Color SailColor;


    // Use this for initialization
    void Start () {

        AS = this.gameObject.GetComponent<AudioSource>();
        BA = BackgroundAudio.GetComponent<AudioSource>();
        LoadTime = 0f;

	}
	
	// Update is called once per frame
	void Update () {

        LoadTime = LoadTime + Time.deltaTime;
        

        if (LoadTime > StartTime)
        {
            FloatUp();
            Debug.Log("called");
        }
        
        if (Player.transform.position.y > AccelerationPoint && MusicPlay == true)
        {
            AS.Play();
            //BA.Play();
            MusicPlay = false;
        }

    }

    void FloatUp()
    {

        if(Player.transform.position.y > AccelerationPoint)
        {
            FloatSpeed += Acceleration;
            //AS.volume -=  Acceleration*2;
        }

        if (Player.transform.position.y > AccelerationPoint2)
        {
            FloatSpeed += Acceleration*30;
            AS.volume -= Acceleration * 2;
            //AS.volume -= Acceleration;
        }

        if (Player.transform.position.y > AccelerationPoint2)
        {
            FloatSpeed += Acceleration * 30;
            //AS.volume -= Acceleration;
        }

        if (FloatSpeed > MaxSpeed)
        {
            FloatSpeed = MaxSpeed;
        }

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
            if (Player.transform.position.y > FloatEndPositionY)
            {
                Sail.SetActive(true);
                Moment.SetActive(false);
                PlayerCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
            PlayerCamera.GetComponent<Camera>().backgroundColor = SailColor;

        }
    }
}
