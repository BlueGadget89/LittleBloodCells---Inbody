using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bullet_behavior : MonoBehaviour
{

    public float timer;
    public float BS; //bullet speed
    public float bulletTimer;

    public GameObject outcome; // game object called outcome

    public Vector3 mousePos;
    public Vector3 direction; // direction that the "outcome" is facing

    public string sceneName;

    public void Awake()
    {
        //outcome = GameObject.Find("outcome");

    }
    public void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName == "Hand_Level" || sceneName == "Heart_Level")
        {
            bulletTimer = 0.3f;
        }
        if (sceneName == "Brain level")
        {
            bulletTimer = 0.5f;
        }

        // mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//set mouse postion
        //direction = mousePos - outcome.transform.position;
        //mousePos - outcome.transform.position;

    }
    public void Update()
    {

        // Debug.Log(direction);
        timer += Time.deltaTime;
        if (timer >= bulletTimer) { Destroy(gameObject); }

        else if(timer <= bulletTimer)
        {
            transform.Translate(Vector2.right * BS * Time.deltaTime);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(direction.x * BS, direction.y * BS, 0);
            //GetComponent<Rigidbody2D>().velocity = Vector3.Angle(transform.forward, direction);

        }       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); 
    }



}
