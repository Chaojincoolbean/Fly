using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

	AudioSource AS;
	public AudioClip DyingHeartAudio;
	bool DyingHeartPlay = true;
    bool LoadScene = false;
	public int LoadTime;

	// Use this for initialization
	void Start () {

		AS = this.gameObject.GetComponent<AudioSource> ();
    }
	
	// Update is called once per frame
	void Update () {

		if (Time.time > 16 & DyingHeartPlay == true) {
			AS.clip = DyingHeartAudio;
			AS.Play ();
			DyingHeartPlay = false;
		}

		if (Time.time > LoadTime) {

            StartCoroutine(LoadNextScene());
		}


    }

    IEnumerator LoadNextScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

        while (!asyncLoad.isDone)
        {
            yield return null; //wait
        }
             
    }
}
