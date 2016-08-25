using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BoostCollision : MonoBehaviour
{
    //Boost
    public GameObject BoostAsset;

    //UI
    public Text BoostName;

    void OnCollisionEnter(Collision hit)
    {
        if (hit.transform.gameObject.tag == "Player")
        {
            BoostAsset.active = false;
            print("self");

        }
    }

}

