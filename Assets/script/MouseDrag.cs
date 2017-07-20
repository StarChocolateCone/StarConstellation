using System.Collections;
using UnityEngine;

public class MouseDrag : MonoBehaviour
{
	Vector3 oldObjectPositon;

	void OnMouseDrag()
	{
		oldObjectPositon = this.transform.position;

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

	void OnCollisionStay2D()
	{
		Debug.Log ("X:" + oldObjectPositon.x);
		Debug.Log ("Y:" + oldObjectPositon.y);
	}

	void OnCollisionExit2D()
	{
		this.transform.position = oldObjectPositon;
	}
}