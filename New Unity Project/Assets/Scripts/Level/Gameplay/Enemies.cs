using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
    private float health = 100f;
    public float points;
    public Transform Player;
    public GameObject self;
    public float Speed = 50;

    private void awake()
    {

    }

    private void start()
    {
       
    }

    public void EnemyAirBasic()
    {

        
        transform.LookAt(Player);
        
        
        /*
        if (health == 0)
        {
           
        }
        */
    }

    /*public float EnemyGroundBasic()
    {
        transform.LookAt(Player.transform);
        points += 10;
        return points; 
        /*if (health == 0)
        {
            
        }
        

    }*/
    
}
