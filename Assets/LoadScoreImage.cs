using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScoreImage : MonoBehaviour {

    // Use this for initialization
    public Image ScoreImage;
    public Texture[] tex;

    void Start () {
        
        switch (Stage.stageName)
        {
            case "Spring":
                if (Stage.missCount <= 1)
                {
                    ScoreImage.material.mainTexture = tex[0];
                }
                else if (Stage.missCount <= 4)
                {
                    ScoreImage.material.mainTexture = tex[1];
                }
                else if (Stage.missCount <= 5)
                {
                    ScoreImage.material.mainTexture = tex[2];
                }
                else
                {
                    ScoreImage.material.mainTexture = tex[3];
                }
                break;
            case "Summer":
                if (Stage.missCount <= 1)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_S") as Texture;
                }
                else if (Stage.missCount <= 6)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_A") as Texture;
                }
                else if (Stage.missCount <= 9)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_B") as Texture;
                }
                else
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_C") as Texture;
                }
                break;
            case "Autumn":
                if (Stage.missCount <= 1)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_S") as Texture;
                }
                else if (Stage.missCount <= 3)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_A") as Texture;
                }
                else if (Stage.missCount <= 4)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_B") as Texture;
                }
                else
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_C") as Texture;
                }
                break;
            case "Winter":
                if (Stage.missCount <= 1)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_S") as Texture;
                }
                else if (Stage.missCount <= 6)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_A") as Texture;
                }
                else if (Stage.missCount <= 12)
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_B") as Texture;
                }
                else
                {
                    ScoreImage.material.mainTexture = Resources.Load("R_C") as Texture;
                }
                break;
        }
        ScoreImage.rectTransform.position = new Vector3(0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
