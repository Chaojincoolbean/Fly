using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartManager : MonoBehaviour {

    bool LoadScene = false;
	public int LoadTime;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {


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
