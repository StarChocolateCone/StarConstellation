using System.Collections;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
	Vector3 oldObjectPositon;
    bool collisionFlag = false;
    public Sprite NowSprite;
    public int movecount;
    SpriteRenderer Renderer;
    string SpriteName;
    public Sprite GetSprite(string fileName, string spriteName)
    {
        Sprite[] LoadSprite = Resources.LoadAll<Sprite>(fileName);
        return System.Array.Find<Sprite>(LoadSprite, (sprite) => sprite.name.Equals(spriteName));
    }

    private void Start()
    {
        oldObjectPositon = this.transform.position;
        //NowSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    void OnMouseDrag()
    {
        Vector3 objectPointInScreen
        = Camera.main.WorldToScreenPoint(this.transform.position);

        Vector3 mousePointInScreen
        = new Vector3(Input.mousePosition.x,
            Input.mousePosition.y,
            objectPointInScreen.z);

        Vector3 mousePointInWorld = Camera.main.ScreenToWorldPoint(mousePointInScreen);
        mousePointInWorld.z = this.transform.position.z;
        this.transform.position = mousePointInWorld;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        collisionFlag = true;
    }

    void OnCollisionStay2D(Collision2D coll)
	{
		Debug.Log ("X:" + oldObjectPositon.x);
		Debug.Log ("Y:" + oldObjectPositon.y);

        oldObjectPositon = this.transform.position;
    }

	void OnCollisionExit2D(Collision2D coll)
    {
        this.transform.position = oldObjectPositon;
    }

    private void OnMouseUp()
    {
        movecount--;
        if(movecount == 0)
        {
            SpriteName = "node_point";
            Sprite TempSprite = GetSprite("Node", SpriteName);
            Renderer = gameObject.GetComponent<SpriteRenderer>();
            Renderer.sprite = TempSprite;
        }
        else
        {
            SpriteName = "node" + movecount;
            Sprite TempSprite = GetSprite("Node", SpriteName);
            Renderer = gameObject.GetComponent<SpriteRenderer>();
            Renderer.sprite = TempSprite;
        }

        if (!collisionFlag)
        {
            oldObjectPositon = this.transform.position;
        }
    }
}