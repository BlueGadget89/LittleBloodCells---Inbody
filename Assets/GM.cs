﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GM : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Player;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    // Start is called before the first frame update
    void Awake()
    {
    }
    void Start()
    {
        
        spwaner();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 2)
        {
            Destroy(heart1);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 1)
        {
            Destroy(heart2);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Destroy(heart3);
        }
    }
    void spwaner()
    {
        // spwans pos for enemy
        Vector3 Sp1 = new Vector3(-13.29f, 4.26f, 0);
        Vector3 Sp2 = new Vector3(-12.23f, -3.0f, 0);
        Vector3 Sp3 = new Vector3(-6.158f, -5.991f, 0);
        Vector3 Sp4 = new Vector3(5.97f, -5.991f, 0);// needs to turn 180 on Z
        Vector3 Sp5 = new Vector3(11.23f, -2.786f, 0);
        Vector3 Sp6 = new Vector3(13.3f, 3.98f, 0);

        // spwaning enemys
        Instantiate(enemy, Sp1, Quaternion.identity);
        Instantiate(enemy, Sp2, Quaternion.identity);
        Instantiate(enemy, Sp3, Quaternion.Euler(0, 0, 180));// needs to turn 180 on Z
        Instantiate(enemy, Sp4, Quaternion.identity);
        Instantiate(enemy, Sp5, Quaternion.identity);
        Instantiate(enemy, Sp6, Quaternion.identity);


    }
    void heart()
    {
        
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 2)
        {
            Destroy(heart1);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 1)
        {
            Destroy(heart2);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Destroy(heart3);
        }

    }


}
