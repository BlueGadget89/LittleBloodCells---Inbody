using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    
    public bool gameover = false; 
    //movement things
    public float moveSpeed = 5f;
    public float JumpForce = 10f;
    public bool canjump;
    //Hp and damgage
    public int playerHp;
    public float deathzone;
    public Vector3 Spwan;// where player spwans
    //attack
    public GameObject outcome;
    public Transform Q;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Transform>().position = Spwan;
        playerHp = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 playerPos = gameObject.GetComponent<Transform>().position;
        if (gameover == false)
        {
            Q.transform.rotation = Quaternion.Euler(0.0f, 0.0f, gameObject.transform.rotation.z * -1.0f);
            if (playerHp <= 0)
            {
                gameover = true; 
            }
            if (gameObject.transform.position.y < deathzone)//falling 
            {
                gameObject.GetComponent<Transform>().position = Spwan;
                playerHp -= 1;
            }
            if (canjump)
            {
                Jump();
            }
            move();
          
            
        }
        else if (gameover == true)
        {
            Destroy(gameObject);
        }
        if (canjump == false)
        {
            GetComponent<Animator>().Play("Jump");
        }

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, JumpForce), ForceMode2D.Impulse);
            canjump = false;
            GetComponent<Animator>().Play("Jump");
        }
    }
   
    private void OnCollisionEnter2D(Collision2D collision) // triggers the jump to reset
    {
        canjump = true;
        if (canjump == true)
        {
            GetComponent<Animator>().Play("Idle");
        }

    }
    void move()
    {
        Vector3 movementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);// moveing left and right
        transform.position += movementInput * Time.deltaTime * moveSpeed;// the "moveing part" aka where the value gets add

        if (movementInput.x > 0) {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
            GetComponent<Animator>().Play("PlayerMovement");
        }
        else if (movementInput.x < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            GetComponent<Animator>().Play("PlayerMovement");
        }

        if (movementInput.x == 0)
        {
            if (canjump == true)
            {
                GetComponent<Animator>().Play("Idle");
            }
        }


    }
   
}
