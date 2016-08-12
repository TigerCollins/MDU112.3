using UnityEngine;
using System.Collections;

public class ESC_Pause : MonoBehaviour {
	public GameObject Pause;

	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Pause.SetActive(true);
		Time.timeScale = 0.0f;
	}
}
