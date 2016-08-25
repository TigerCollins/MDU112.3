using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
    //General
    [SerializeField] // Allows Unity to modify variable via inspector.
    private GameObject PauseMenu;

    //Player Movement
    private Rigidbody rb;
    private float playerSpeedMultiplier = 75f;

    //Player Rotation
    private float rotationspeed = 6f;
    private float x, y = 0;

    //Player Stats
    private float Health = 100;
    public float dmg = 25;
    

    //UI
    public Text HealthAmount;
    public Image healthSlider;
    public Text EnemyAmount;
    public Image enemySlider;
    public float Enemies = 1;
    public Text boostRemaining;
    public Image boostSlider;
    public Text ScoreText;
    

    
    //Player Combat
    private float ProjectileForce = 40000f;
    public GameObject Projectile;
    public GameObject ProjectileSpawner;

    //Boost
    [SerializeField]
    private float Boost;
    public GameObject boostAsset;
    private float boostTimer;



    //Constructor
    // [SerializeField]



    void OnCollisionEnter(Collision hit)
    {
       if (hit.transform.gameObject.tag == "Boost")
        {
            Boost = 10f;
            print("swag");
        }
    }

    void Awake()
    {
       rb = gameObject.GetComponent<Rigidbody>();
    }

    		
	void Update ()
    {
        //UI
        HealthAmount.text = Health.ToString();
        healthSlider.fillAmount = Health / 100;

        EnemyAmount.text = Enemies.ToString();
        enemySlider.fillAmount = Enemies / 8;
        Enemies = (GameObject.FindGameObjectsWithTag("Enemy").Length);

       
       
        

        boostRemaining.text = (Boost * 10).ToString("F0");
        boostSlider.fillAmount = (Boost*10) / 100;

        //Boost

        if (Boost > 0)
        {
            Boost = Boost - Time.deltaTime;
        }

        else
        {
            Boost = 0;
        }
        
        //Player Movement
        if (Input.GetKey("w"))
        {
            rb.MovePosition(transform.position + transform.forward * (Time.deltaTime*playerSpeedMultiplier));
        }
        
        if (Input.GetKey("s"))
        {
            rb.MovePosition(transform.position - transform.forward * (Time.deltaTime*playerSpeedMultiplier));
        }

        //Player Rotation
        x += Input.GetAxis("Mouse X") * rotationspeed;
        y -= Input.GetAxis("Mouse Y") * rotationspeed;
        transform.eulerAngles = new Vector3(y, x);

        if (PauseMenu.activeInHierarchy == true)
        {
            rotationspeed = 0f;
            Screen.lockCursor = false;
            Time.timeScale = 0f;
        }
        else
        {
            rotationspeed = 6f;
            Screen.lockCursor = true;
            Time.timeScale = 1f;
        }

        //Player Combat

        if (Input.GetMouseButtonDown(0))
        {
            GameObject Laser; //TUTORIAL FOLLOWED FROM (http://answers.unity3d.com/questions/19710/shooting-a-bullet-projectile-properly.html)
            Laser = Instantiate(Projectile, ProjectileSpawner.transform.position, ProjectileSpawner.transform.rotation) as GameObject;
            Laser.transform.Rotate(90, 90, 0);
            Rigidbody LaserRigidBody;
            LaserRigidBody = Laser.GetComponent<Rigidbody>();
            LaserRigidBody.AddForce(transform.forward * ProjectileForce);
            Destroy(Laser, 4);
        }

        //GameOver
        if(Enemies == 0)
        {
            Screen.lockCursor = false;
            Application.LoadLevel("GameOver");
        }

        if (Health == 0f)
        {
            Screen.lockCursor = false;
            Application.LoadLevel("GameOver");

        }

        //Score
        float MaxEnemies = 80;

        ScoreText.text = (MaxEnemies - (Enemies*10)).ToString("f0");
	}

    public void BoostName()
    {
        int[] numbers = new int[2] { 1, 2 };
        string[] names = new string[2] { "Health Boost", "Damage Boost" };
    }
   

}
