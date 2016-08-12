using UnityEngine;
using System.Collections;

public class MouseCamera : MonoBehaviour {
	public float rotationspeed = 6f;
	public float x,y = 0;

	void Update()
	{
		x += Input.GetAxis ("Mouse X") * rotationspeed;
		y -= Input.GetAxis ("Mouse Y") * rotationspeed;
		transform.eulerAngles = new Vector3 (y, x);
	}
}
