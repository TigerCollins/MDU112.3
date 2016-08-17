using UnityEngine;
using System.Collections;

public class PlayerRotate : MonoBehaviour {

    public float rotationspeed;
    public float x, y = 0;
    public GameObject PauseMenu;

    void Update()
    {
        x += Input.GetAxis("Mouse X") * rotationspeed;
        y -= Input.GetAxis("Mouse Y") * rotationspeed;
        transform.eulerAngles = new Vector3(y, x);

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
