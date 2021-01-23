using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed = 7f;
    public Vector3 leftMoveForce;
    public Vector3 rightMoveForce;
    public bool flip;
    public Vector3 jumpForce;
    //public int doubleJump;
    //public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Jump();

        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(rightMoveForce);
            flip = true;
            //playerFacing = 1;

            if (flip == true)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(leftMoveForce);
            flip = false;
            //playerFacing = -1;
            if (flip == false)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }

        }

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(jumpForce);

            //doubleJump += 1;
            //if (canJump == true)
            //{
                //GetComponent<Rigidbody2D>().AddForce(jumpForce);
            //}
            //if (doubleJump >= 2)
            //{
                //doubleJump = 0;
                //canJump = false;
            //}
        }
    }

    //void Jump()
    //{
        //if (Input.GetButtonDown("Jump"))
        //{
            //gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        //}
    //}
}
