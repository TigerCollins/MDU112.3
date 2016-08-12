using UnityEngine;
using System.Collections;

public class Pause_ToMenu : MonoBehaviour {

	public void LoadMenu () {
		Application.LoadLevel ("Main Menu"); //Load the menu
		print ("Loading Level");
	}
}
