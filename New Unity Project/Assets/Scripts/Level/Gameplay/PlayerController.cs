using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Player Movement
    private Vector2 userInput;
    private Rigidbody rb;
    public float InputScaleX = 0.1f;
    public float InputScaleY = 0.1f;
    public float thrust = 50;

    //Player Stats
    public float Health = 100;
    private float dmg = 100;
    private float Score = 10;

    //UI
    public Text HealthAmount;
    public Image healthSlider;
    public Text EnemyAmount;
    public Image enemySlider;
    private float Enemies = 4;
    public Text ScoreText;



    void Awake()
    {
       rb = gameObject.GetComponent<Rigidbody>();
    }
	
	void Start ()
    {
	
	}
	
	void Update ()
    {
        //UI
        HealthAmount.text = Health.ToString();
        healthSlider.fillAmount = Health / 100;

        EnemyAmount.text = Enemies.ToString();
        enemySlider.fillAmount = Enemies / 8;

        ScoreText.text = Score.ToString();

        //Player Movement
        userInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Health == 0f)
        {
            Screen.lockCursor = false;
            Application.LoadLevel("GameOver");

        }
       
	}

    void FixedUpdate()
    {
       rb.MovePosition(transform.position + new Vector3 (userInput.x * InputScaleX, 0, userInput.y * InputScaleY));
       
    }
}
