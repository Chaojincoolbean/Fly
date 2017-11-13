using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

		RaycastHit rayHit = new RaycastHit();

		if (Physics.Raycast (ray, out rayHit, 10000f)) {
			if (rayHit.transform ==this.transform){
				transform.localScale *= 1.1f;
			}
		}
		
	}
}
