using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.Events;

public class TimedGazeTrigger : MonoBehaviour {

	[SerializeField] float timeLookedAt = 0f; //time in seconds, we've spent looking at this thing.
	public Camera PlayerCamera;
	public GameObject TitleEnglish;
    public UnityEvent OnGazeComplete = new UnityEvent(); 
    private Color TitleColor;
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 camLookDir = PlayerCamera.transform.forward;

		Vector3 VectorFromCamToTarget = transform.position - PlayerCamera.transform.position;

		float angle = Vector3.Angle (camLookDir, VectorFromCamToTarget);

		if (angle < 15f *transform.localScale.x) {
			
			timeLookedAt =  timeLookedAt + Time.deltaTime;   //after 1 second, this variable will be 1f
            Debug.Log("timeLookedAt:"+ timeLookedAt);
            TitleColor.a = 1 - timeLookedAt/10;
            Debug.Log(TitleColor.a);
            
            if(TitleColor.a < 0)
            {
                TitleColor.a = 0;
            }
            this.gameObject.GetComponent<SpriteRenderer>().color = TitleColor;
            TitleEnglish.gameObject.GetComponent<SpriteRenderer>().color = TitleColor;
            //Debug.Log(TitleColor.a);
			//Debug.Log("timeLookedAt:"+ timeLookedAt);

            if (TitleColor.a == 0) {
                Debug.Log("invoke");
                //timeLookedAt = 0f;
				OnGazeComplete.Invoke ();	//fire any events accosiating this event
			}
		}

		else{
			
			//timeLookedAt = Mathf.Clamp01 (timeLookedAt - Time.deltaTime);

		}
	}
}
