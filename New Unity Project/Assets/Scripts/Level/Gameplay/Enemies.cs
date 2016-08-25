using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{

    //Stats
    public float health = 100;

    //boost
    public GameObject BoostAsset;
    public GameObject BoostSpawner;

    void OnCollisionEnter(Collision hit)
    {
      
        if (hit.gameObject.tag == "Laser")
        {
           
            health = health - 20;
            if (health < 0)
            {               
               
                Destroy(gameObject);
                GameObject Boost;
                Boost = Instantiate(BoostAsset, BoostSpawner.transform.position, BoostSpawner.transform.rotation) as GameObject;
                Update();
            }
                        
        }
    }
        

	// Update is called once per frame
	void Update ()
    {
        
       

    }
        
}
