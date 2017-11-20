using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    bool LoadScene = false;
	public int LoadTime;
	public GameObject Canvas;
	public GameObject HeartBeatGroup;
	public GameObject HeartBeatGroup1;
    public GameObject HeartBeatGroup2;
	public GameObject Mask;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

		if (Time.time > 15f) {
			Canvas.SetActive (false);
			HeartBeatGroup.SetActive (true);
			Mask.SetActive (true);
		}

		if (Time.time > 83f) {
		
			HeartBeatGroup.SetActive (false);
			HeartBeatGroup1.SetActive (true);
		}

        if (Time.time > 90f) {

            Mask.SetActive(false);
            HeartBeatGroup1.SetActive(false);
            HeartBeatGroup2.SetActive(true);

        }

		if (Time.time > 94f) {
			
			//StartCoroutine(LoadNextScene());
			SteamVR_LoadLevel.Begin("Moment", false, 1, 1, 1, 1, 1);
        }

    }

//   IEnumerator LoadNextScene()
//    {
        
//		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

 //       while (!asyncLoad.isDone)
//        {
//				yield return null; //wait
//        }

//		while (Time.time < LoadTime) {
//			
//			 	yield return null; //wait
//		}
             
//    }
}
