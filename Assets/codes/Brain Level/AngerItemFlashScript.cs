using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngerItemFlashScript : MonoBehaviour
{
    public GameObject anger1, anger2, anger3, anger4, anger5;
    public float flashTimer;
    public bool isFlashing;
    public float boolTimer;
    public GameObject angerCamera;
    public bool firstFlash;

    // Start is called before the first frame update
    void Start()
    {
        anger1.GetComponent<SpriteRenderer>().enabled = false;
        anger2.GetComponent<SpriteRenderer>().enabled = false;
        anger3.GetComponent<SpriteRenderer>().enabled = false;
        anger4.GetComponent<SpriteRenderer>().enabled = false;
        anger5.GetComponent<SpriteRenderer>().enabled = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (angerCamera.GetComponent<Camera>().enabled == true && isFlashing == false && firstFlash == false)
        {
            isFlashing = true;
        }
        if (isFlashing == true)
        {
            flashTimer += Time.deltaTime;
            boolTimer += Time.deltaTime;
        }
        if (flashTimer >= 0.25)
        {
            anger1.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (anger1.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 0.75)
        {
            anger2.GetComponent<SpriteRenderer>().enabled = true;
            anger1.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (anger2.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.25)
        {
            anger3.GetComponent<SpriteRenderer>().enabled = true;
            anger2.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (anger3.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.75)
        {
            anger4.GetComponent<SpriteRenderer>().enabled = true;
            anger3.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (anger4.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 2.25)
        {
            anger5.GetComponent<SpriteRenderer>().enabled = true;
            anger4.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (anger5.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 2.75)
        {
            flashTimer -= Time.deltaTime;
            anger5.GetComponent<SpriteRenderer>().enabled = false;
            flashTimer = 0;
        }
        if (boolTimer >= 2.75)
        {
            isFlashing = false;
            firstFlash = true;
            boolTimer -= Time.deltaTime;
            boolTimer = 0;
        }
    }
}