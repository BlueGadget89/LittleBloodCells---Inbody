﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiming : MonoBehaviour
{
    public Vector3 mousePos;
    public GameObject bullet;
    public GameObject outcome;
    public float angle;
    public float adjestment;
    // Start is called before the first frame update
    void Start()
    {
        
        outcome = GameObject.Find("outcome");
    }

    // Update is called once per frame
    private void Update()
    {
          mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);//set mouse postion from world to seance

        // weapon roation
        Vector3 aimDirection = mousePos - transform.position; //get the distance for trig
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg; // trig and the angle caclualtion
        transform.rotation = Quaternion.Euler(0, 0, angle + adjestment);

        //shoting
        if (Input.GetMouseButtonDown(0))
        {

            Vector3 outcomepos = outcome.GetComponent<Transform>().position;

            Instantiate(bullet, outcomepos, transform.rotation);
        }
    }
    
}
 