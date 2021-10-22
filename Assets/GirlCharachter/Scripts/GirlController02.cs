using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GirlController02 : MonoBehaviour
{
    public GameObject textdisplay;
    public int secondsLeft = 10;
    public bool takingaway = false;


    //variables of coin
    public AudioSource tenpointcoinsound;
    public AudioSource hundredpointcoinsound;
    public AudioSource maxiss99seconds;
    //int score = 0;
   // public Text Textscore;

    //serializefield variables of player movements
    [SerializeField] private float walkspeed;
    [SerializeField] private float runspeed;
    [SerializeField] private float movespeed;
    [SerializeField] private float jumpHeight;
    [SerializeField] private bool isgrounded;
    [SerializeField] private float groundcheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;

    //[SerializeField] private float turnsmoothtime = 0.1f;
    //private float turnsmoothvelocity;

    //variable
    private Vector3 moveforward;
    private Vector3 velocity;

    private CharacterController controller;
    private Animator anim;
    public GameObject Door;


    //calling functions in the begining of the game
    private void Start()
    {
        textdisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        
    }

    //calling functions in every frame of the game
    private void Update()
    {
        if (secondsLeft == 0)
        {
            SceneManager.LoadScene("GameOver02");
        }

        if (takingaway == false && secondsLeft > 0)
        {
            StartCoroutine(TimeTake());
        }
        
        Move();
    }

   


    //player's all movements
    private void Move()
    {
        isgrounded = Physics.CheckSphere(transform.position, groundcheckDistance, groundMask);

        if(isgrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float movez = Input.GetAxisRaw("Vertical");
       // float movex = Input.GetAxisRaw("Horizontal");
        moveforward = new Vector3(0, 0, movez).normalized;
        
        //move player to player's direction not to world direction
       moveforward = transform.TransformDirection(moveforward);


        if (moveforward != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            Walk();
            anim.SetFloat("Speed", 0.5f, 0.1f, Time.deltaTime);
        }

        else if (moveforward != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Run();
            anim.SetFloat("Speed", 1f, 0.1f, Time.deltaTime);
        }

        else if (moveforward == Vector3.zero)
        {
            Idle();
            anim.SetFloat("Speed", 0f, 0.1f, Time.deltaTime);
        }


        if (isgrounded)
        {
           

            //calling jump function when pressed space
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

           
        }

       

        

       

        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("rrrrrrrrrrrrrrrrrrrrrrrrr");
            Destroy(Door);
        }

        //rotate player to the input direction
        /*float targetangle = Mathf.Atan2(moveforward.x, moveforward.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnsmoothvelocity, turnsmoothtime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);*/

        controller.Move(moveforward * movespeed * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    //walk function 
    private void Walk()
    {
        movespeed = walkspeed;
    }

    //run function
    private void Run()
    {
        movespeed = runspeed;
    }

    //idle function
    private void Idle()
    {
       movespeed = 0;
    }

    //jump function
    private void Jump()
    {
       velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
       anim.SetTrigger("Jumpp");

        
    }

    //dance function
    private void Dance()
    {
        anim.SetTrigger("Dance");

    }

    //roll function
    private void Roll()
    {
        anim.SetTrigger("Roll");
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "TimeGem")
        {
           // Destroy(coin);
            tenpointcoinsound.Play();
            secondsLeft += 5;
            
            //SetScore();
        }

        if (coll.gameObject.tag == "PointStar")
        {
            // Destroy(coin);
            tenpointcoinsound.Play();
            secondsLeft += 10;
            //SetScore();
        }

        if (coll.gameObject.tag == "RedCoin")
        {
            // Destroy(coin);
            hundredpointcoinsound.Play();
            secondsLeft += 10;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // SetScore();
        }

        if (coll.gameObject.tag == "Door")
        {
          
                Debug.Log("ddddddddddddddddddddddddddd");
                
             // Destroy(coin);
            
            // SetScore();
        }
    }

   /* void SetScore()
    {
        Textscore.text = "Score: " + score;
        //Debug.Log(score);
    }*/

    IEnumerator TimeTake()
    {
        if(secondsLeft >= 99)
        {
            secondsLeft = 99;
            maxiss99seconds.Play();
        }

        


        takingaway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;
        textdisplay.GetComponent<Text>().text = "00:" + secondsLeft;
        takingaway = false;
    }

}
