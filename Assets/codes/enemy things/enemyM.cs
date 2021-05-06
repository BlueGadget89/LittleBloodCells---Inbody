﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyM : MonoBehaviour
{
    public GameObject Player;
    public AudioSource audio;
    //Dictates how fast the entity will move across the platform
    public float speed;
    //Dictate which direction the entity must move once it reaches the edge of the platform
    private bool movingRight = true;
    public GameObject gameManager;

    public Transform groundDetection;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GM");

        //This helps the script detect what the current scene is
        Scene currentScene = SceneManager.GetActiveScene();

        //This sets a string to have the name of the current scene as it's text
        sceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        //This is the automatic movement function for the entity.
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //Sets the origin, direction and length of the raycast detector, respectively to items in parantheses
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 1.2f);
        //Tells the item when to switch directions
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                //Flips the entity around
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }

        GetComponent<Animator>().Play("EnemyMovement");
    }



  
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == ("bullet"))
        {
            audio.Play();
            Destroy(other.gameObject);
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            Destroy(gameObject.GetComponent<CircleCollider2D>());
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            if (sceneName == "Hand_Level")
            {
                gameManager.GetComponent<GM>().enemiesKilled += 1;
            }
            if (sceneName == "Heart_Level")
            {
                gameManager.GetComponent<Heart_GM>().enemiesKilled += 1;
            }
        }

    }

}