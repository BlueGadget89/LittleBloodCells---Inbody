using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_behavior : MonoBehaviour
{

    public float timer;
    public float BS; //bullet speed

    public GameObject outcome; // game object called outcome

    public Vector3 mousePos;
    public Vector3 direction; // direction that the "outcome" is facing

    public void Awake()
    {
        //outcome = GameObject.Find("outcome");

    }
    public void Start()
    {

        // mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//set mouse postion
        //direction = mousePos - outcome.transform.position;
        //mousePos - outcome.transform.position;

    }
    public void Update()
    {
        

        // Debug.Log(direction);
        timer += Time.deltaTime;
        if (timer >= 2) { Destroy(gameObject); }

        else if(timer <= 2)
        {
            transform.Translate(Vector2.right * BS * Time.deltaTime);
            //GetComponent<Rigidbody2D>().velocity = new Vector3(direction.x * BS, direction.y * BS, 0);
            //GetComponent<Rigidbody2D>().velocity = Vector3.Angle(transform.forward, direction);

        }


       

    }



}
