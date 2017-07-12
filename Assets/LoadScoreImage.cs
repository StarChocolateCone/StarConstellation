using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScoreImage : MonoBehaviour {

    // Use this for initialization
    public Image ScoreImage;
    public Texture2D texture;
    public enum SCORE
    {
        S,A,B,C
    }

    public SCORE score;
    void Start () {
        
        switch (Stage.stageName)
        {
            case "Spring":
                if (Stage.missCount <= 1)
                {
                    score = SCORE.S;
                }
                else if (Stage.missCount <= 4)
                {
                    score = SCORE.A;
                }
                else if (Stage.missCount <= 5)
                {
                    score = SCORE.B;
                }
                else
                {
                    score = SCORE.C;
                }
                break;
            case "Summer":
                if (Stage.missCount <= 1)
                {
                    score = SCORE.S;
                }
                else if (Stage.missCount <= 6)
                {
                    score = SCORE.A;
                }
                else if (Stage.missCount <= 9)
                {
                    score = SCORE.B;
                }
                else
                {
                    score = SCORE.C;
                }
                break;
            case "Autumn":
                if (Stage.missCount <= 1)
                {
                    score = SCORE.S;
                }
                else if (Stage.missCount <= 3)
                {
                    score = SCORE.A;
                }
                else if (Stage.missCount <= 4)
                {
                    score = SCORE.B;
                }
                else
                {
                    score = SCORE.C;
                }
                break;
            case "Winter":
                if (Stage.missCount <= 1)
                {
                    score = SCORE.S;
                }
                else if (Stage.missCount <= 6)
                {
                    score = SCORE.A;
                }
                else if (Stage.missCount <= 12)
                {
                    score = SCORE.B;
                }
                else
                {
                    score = SCORE.C;
                }
                break;
        }

        switch(score)
        {
            case SCORE.S:
                texture = Resources.Load("R_S") as Texture2D;
                break;
            case SCORE.A:
                texture = Resources.Load("R_A") as Texture2D;
                break;
            case SCORE.B:
                texture = Resources.Load("R_B") as Texture2D;
                break;
            case SCORE.C:
                texture = Resources.Load("R_C") as Texture2D;
                break;
        }

        ScoreImage.sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
