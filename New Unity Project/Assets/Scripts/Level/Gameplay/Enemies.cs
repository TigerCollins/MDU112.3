using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {
    private float health = 100f;
    public float points;
    public Transform Player;
    public GameObject self; 
    public PlayerController PlayerController;
    [SerializeField]
    private float enemiesLeft;

  


    private void awake()
    {

      
    }

    public void start()
    {
        //PlayerController.EnemyCount = enemiesLeft;
        enemiesLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;
        print("Oh no!" + enemiesLeft);
    }

    public void update()
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
