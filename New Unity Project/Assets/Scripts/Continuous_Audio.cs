using UnityEngine;
using System.Collections;

public class Continuous_Audio : MonoBehaviour {

	public void Start()//From http://answers.unity3d.com/questions/233284/objects-being-duplicated-with-dontdestroyonload.html
	{
		DontDestroyOnLoad(gameObject);
		if (FindObjectsOfType(GetType()).Length > 1)
		{
			Destroy(gameObject);
		}
	}
}
