using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadReslutImage : MonoBehaviour {
    // Use this for initialization
    public Image ConstellationImage;

    void Start ()
    {
        switch (Stage.stageName)
        {
            case "Spring":
                ConstellationImage.material.mainTexture = Resources.Load("R_kani") as Texture;
                break;
            case "Summer":
                ConstellationImage.material.mainTexture = Resources.Load("R_wasi") as Texture;
                break;
            case "Autumn":
                ConstellationImage.material.mainTexture = Resources.Load("R_ohi") as Texture;
                break;
            case "Winter":
                ConstellationImage.material.mainTexture = Resources.Load("R_usa") as Texture;
                break;
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
