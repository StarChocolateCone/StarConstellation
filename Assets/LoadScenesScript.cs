using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LoadScenesScript : MonoBehaviour {

    // Use this for initialization
    public string nextScene;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        if(nextScene == "End")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
