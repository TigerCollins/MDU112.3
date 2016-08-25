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
    public Text boostName;
    public float damageTake = 20f;

    void OnCollisionEnter(Collision hit)
    {
      
        if (hit.gameObject.tag == "Laser")
        {
           
            health = health - damageTake;
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
        if (boostName.text == "Damage Boost")
        {
            damageTake = 40;
        }

        else
        {
            damageTake = 20;
        }


    }
        
}
