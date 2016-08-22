using UnityEngine;
using System.Collections;


public class BulletCollision : MonoBehaviour
{

    void OnCollisionEnter()
    {
        Destroy(gameObject);

    }


}
