using UnityEngine;
using System.Collections;

public class MouseCamera : MonoBehaviour {
	public float rotationspeed;
	public float x,y = 0;
    public GameObject PauseMenu;

	void Update()
	{
		x += Input.GetAxis ("Mouse X") * rotationspeed;
		y -= Input.GetAxis ("Mouse Y") * rotationspeed;
		transform.eulerAngles = new Vector3 (y, x);

		if (PauseMenu.activeInHierarchy == true) 
		{
			rotationspeed = 0f;
		} 
		else 
		{
			rotationspeed = 6f;
		}
	}
}
