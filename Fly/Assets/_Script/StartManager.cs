using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

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

        LoadTime = 0f;

    }
	
	// Update is called once per frame
	void Update () {

        LoadTime = LoadTime + Time.deltaTime;

		if (LoadTime > 15f) {
			HeartBeatGroup.SetActive (true);
			Mask.SetActive (true);
		}

        if (LoadTime > 55f)
        {
            //Canvas.SetActive(false);
        }

        if (LoadTime > 99f) {
            Mask.SetActive(false);
            HeartBeatGroup.SetActive(false);
            HeartBeatGroup2.SetActive(true);

        }

		if (LoadTime > 115f) {

            LoadTime = 0f;
            Moment.SetActive(true);
            Dying.SetActive(false);
            PlayerCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
            RenderSettings.skybox = Daytime;

        }

    }
}
