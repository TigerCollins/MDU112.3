using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
    public float health = 100;


	// Use this for initialization
	void Start () {
	
	}
	
    void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.tag == "Laser")
        {
            health = health - 10;
            if (health < 0)
            {
                Destroy(gameObject);
            }
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
