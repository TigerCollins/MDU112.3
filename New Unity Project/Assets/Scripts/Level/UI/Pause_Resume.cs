using UnityEngine;
using System.Collections;

public class Pause_Resume : MonoBehaviour {
	public GameObject Pause;

	public void ResumeGame(){
		Pause.SetActive(false);
		Time.timeScale = 1.0f;
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			Pause.SetActive(false);
		Time.timeScale = 1.0f;
	}
}
