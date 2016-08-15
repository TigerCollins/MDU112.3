using UnityEngine;
using System.Collections;

public class ESC_Pause : MonoBehaviour {
	public GameObject Pause;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.SetActive(true);            
        }

        if (Pause.activeInHierarchy == true)
        {
            Time.timeScale = 0.0f;
        }
      
        else
        {
            Time.timeScale = 1;
        }           
	}
}
