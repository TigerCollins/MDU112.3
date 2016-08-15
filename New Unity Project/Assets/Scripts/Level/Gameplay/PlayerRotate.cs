using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

	public float rotationspeed = 6f;
	public float x,y = 0;
    public GameObject PauseMenu;

		void Update()
		{
			x += Input.GetAxis ("Mouse X") * rotationspeed;
			transform.eulerAngles = new Vector3 (y, x);

       //If the pause menu is active, the user can see the mouse and camera rotation is stopped.
        if (PauseMenu.activeInHierarchy == true)
        {
            rotationspeed = 0f;
            Screen.lockCursor = false;
        }
        else
        {
            rotationspeed = 6f;
            Screen.lockCursor = true;
        }

    }
	}
