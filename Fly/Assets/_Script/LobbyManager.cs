using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNextScene()
    {
        SteamVR_LoadLevel.Begin("Start", false, 05, 1, 1, 1, 1);
        Debug.Log("start");
    }
}
