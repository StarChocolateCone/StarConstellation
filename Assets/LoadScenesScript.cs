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

    public void OnClick(string name)
    {
        SceneManager.LoadScene(nextScene);
        Stage.stageName = name;
        Stage.missCount += 2;
    }
    public void OnClick()
    {
        SceneManager.LoadScene(nextScene);
        Stage.missCount += 2;
    }
}
