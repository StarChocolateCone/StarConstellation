using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadReslutImage : MonoBehaviour {
    // Use this for initialization
    public Image ConstellationImage;
    public Texture2D texture;

    void Start ()
    {
        switch (Stage.stageName)
        {
            case "Spring":
                texture = Resources.Load("R_kani") as Texture2D;
                break;
            case "Summer":
                texture = Resources.Load("R_wasi") as Texture2D;
                break;
            case "Autumn":
                texture = Resources.Load("R_ohi") as Texture2D;
                break;
            case "Winter":
                texture = Resources.Load("R_usa") as Texture2D;
                break;
        }

        ConstellationImage.sprite=Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
