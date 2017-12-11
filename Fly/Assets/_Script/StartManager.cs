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

        LoadTime = 0;

    }
	
	// Update is called once per frame
	void Update () {

        LoadTime = LoadTime + Time.deltaTime;

		if (LoadTime > 20f) {
			HeartBeatGroup.SetActive (true);
			Mask.SetActive (true);
		}

        if (LoadTime > 55f)
        {
            //Canvas.SetActive(false);
        }

        if (LoadTime > 144f) {
            Mask.SetActive(false);
            HeartBeatGroup.SetActive(false);
            HeartBeatGroup2.SetActive(true);

        }

		if (LoadTime > 160f) {

            Moment.SetActive(true);
            Dying.SetActive(false);
            PlayerCamera.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
            RenderSettings.skybox = Daytime;

        }

    }
}
