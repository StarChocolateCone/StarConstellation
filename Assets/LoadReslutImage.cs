using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadReslutImage : MonoBehaviour {
	// Use this for initialization
	void Start ()
    {
        Image img = GameObject.Find("Canvas/Panel/Image").GetComponent<Image>();
        switch(Stage.stageName)
        {
            case "Spring":
                img.material.mainTexture = Resources.Load("st_sp") as Texture;
                break;
            case "Summer":
                img.material.mainTexture = Resources.Load("st_su") as Texture;
                break;
            case "Autumn":
                img.material.mainTexture = Resources.Load("st_au") as Texture;
                break;
            case "Winter":
                img.material.mainTexture = Resources.Load("st_wi") as Texture;
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
