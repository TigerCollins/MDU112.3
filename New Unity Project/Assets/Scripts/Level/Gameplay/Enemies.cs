using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

    //Stats
    public float health = 100;

    //boost
    public GameObject BoostAsset;
    public GameObject BoostSpawner;


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
                GameObject Boost;
                Boost = Instantiate(BoostAsset, BoostSpawner.transform.position, BoostSpawner.transform.rotation) as GameObject;
            }
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
