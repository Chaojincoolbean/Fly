using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.Events;

public class TimedGazeTrigger : MonoBehaviour {

	[SerializeField] float timeLookedAt = 0f; //time in seconds, we've spent looking at this thing.
	public Camera PlayerCamera;
    public Camera PlayerCamera2;
	public GameObject TitleEnglish;
    public GameObject Name;
    //public UnityEvent OnGazeComplete = new UnityEvent(); 
    private Color TitleColor;
    private AudioSource As;

	public GameObject Lobby;
	public GameObject Dying;
    


	// Use this for initialization
	void Start () {

        As = this.gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 camLookDir = PlayerCamera.transform.forward;

		Vector3 VectorFromCamToTarget = transform.position - PlayerCamera.transform.position;

		float angle = Vector3.Angle (camLookDir, VectorFromCamToTarget);

		if (angle < 15f * transform.localScale.x) {
			
			timeLookedAt =  timeLookedAt + Time.deltaTime;   //after 1 second, this variable will be 1f
            TitleColor.a = 1 - timeLookedAt/10;
            As.volume = As.volume - timeLookedAt / 8000;
            
            if(TitleColor.a < 0)
            {
                TitleColor.a = 0;
            }

            this.gameObject.GetComponent<SpriteRenderer>().color = TitleColor;
            TitleEnglish.gameObject.GetComponent<SpriteRenderer>().color = TitleColor;
            Name.gameObject.GetComponent<SpriteRenderer>().color = TitleColor;

            if (TitleColor.a == 0) {
				//OnGazeComplete.Invoke ();	//fire any events accosiating this event
				Dying.SetActive(true);
				Lobby.SetActive (false);
                PlayerCamera2.GetComponent<Camera>().clearFlags = CameraClearFlags.SolidColor;
			}
		}
	}
}
