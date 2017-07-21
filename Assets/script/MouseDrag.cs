using System.Collections;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
	Vector3 oldObjectPositon;
    bool collisionFlag = false;

    private void Start()
    {
        oldObjectPositon = this.transform.position;
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
        if (!collisionFlag)
        {
        }
    }
}