using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    private Vector2 userInput;
    private Rigidbody rb;
    public float InputScaleX = 0.1f;
    public float InputScaleY = 0.1f;
    public float thrust = 50;


    void Awake()
    {
       rb = gameObject.GetComponent<Rigidbody>();
    }
	
	void Start ()
    {
	
	}
	
	void Update ()
    {
        userInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
       
	}

    void FixedUpdate()
    {
       rb.MovePosition(transform.position + new Vector3 (userInput.x * InputScaleX, 0, userInput.y * InputScaleY));
        /* Yet to know how to complete the if statement
   
       if (userInput.x * InputScaleX = true)
       {
           rb.AddForce(transform.forward * thrust);
       }
       
       else
       {

       } 
     */
    }
}
