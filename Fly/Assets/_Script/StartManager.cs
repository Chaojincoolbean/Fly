﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    bool LoadScene = false;
	public float LoadTime;
	public GameObject Canvas;
	public GameObject HeartBeatGroup;
	public GameObject HeartBeatGroup1;
    public GameObject HeartBeatGroup2;
	public GameObject Mask;
    public GameObject Dying;
    public GameObject Moment;
    public Camera PlayerCamera;
    public Material Daytime;

    // Use this for initialization
    void Start () {

        LoadTime = 0;

    }
	
	// Update is called once per frame
	void Update () {

        LoadTime = LoadTime + Time.deltaTime;

        Debug.Log(LoadTime);


		if (LoadTime > 15f) {
			Canvas.SetActive (false);
			HeartBeatGroup.SetActive (true);
			Mask.SetActive (true);
		}

		if (LoadTime > 83f) {
		
			HeartBeatGroup.SetActive (false);
			HeartBeatGroup1.SetActive (true);
		}

        if (LoadTime > 90f) {

            Mask.SetActive(false);
            HeartBeatGroup1.SetActive(false);
            HeartBeatGroup2.SetActive(true);

        }

		if (LoadTime > 94f) {

            Moment.SetActive(true);
            Dying.SetActive(false);
            PlayerCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
            RenderSettings.skybox = Daytime;

        }

    }
}
