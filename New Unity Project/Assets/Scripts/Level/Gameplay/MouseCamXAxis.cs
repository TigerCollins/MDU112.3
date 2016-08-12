using UnityEngine;
using System.Collections;

public class MouseCamXAxis : MonoBehaviour {
	public float rotationspeed = 6f;
	public float x,y = 0;

	void Update()
	{
		x += Input.GetAxis ("Mouse X") * rotationspeed;

		z -= Input.GetAxis ("Mouse Y") * rotationspeed;
		transform.eulerAngles = new Vector3 (y, y);
	}
}
