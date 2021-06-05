using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingplatform : MonoBehaviour
{
    public float movespeed ;
    public float moverange = 15;
    public float endpoint;
    public bool stage1;
    public bool stage2;
    public Vector3 startpoint;
    // Start is called before the first frame update
    void Start()
    {
        startpoint = gameObject.transform.position;
        stage1= true;
        stage2 = false;
    }

    // Update is called once per frame
    void Update()
    {

        updown();
        Debug.Log(endpoint);

    }

    void updown()
    {
        
        endpoint = startpoint.y + moverange;
        if (stage1)
        {
            if (transform.position.y < endpoint)
            {
                transform.position += new Vector3(0, movespeed, 0);
            }
            if (transform.position.y == endpoint)
            {
                stage1 = false;
                stage2 = true;
            }
           
        }
        if (stage2)
        {
            if (startpoint.y < transform.position.y)
            {
                transform.position -= new Vector3(0, movespeed, 0);
            }
            if(transform.position.y == startpoint.y)
            {
                stage1 = true;
                stage2 = false;
            }
        }
      
        
    }
    void leftright()
    {
        endpoint = startpoint.x + moverange;
        if (stage1)
        {
            if (transform.position.x < endpoint)
            {
                transform.position += new Vector3(movespeed, 0, 0);
            }
            if (transform.position.x == endpoint)
            {
                stage1 = false;
                stage2 = true;
            }

        }
        if (stage2)
        {
            if (startpoint.x < transform.position.x)
            {
                transform.position -= new Vector3(movespeed, 0, 0);
            }
            if (transform.position.x == startpoint.x)
            {
                stage1 = true;
                stage2 = false;
            }
        }


    }
}
