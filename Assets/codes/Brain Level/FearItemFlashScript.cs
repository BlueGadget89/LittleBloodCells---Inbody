using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearItemFlashScript : MonoBehaviour
{
    public GameObject fear1, fear2, fear3, fear4, fear5, fear6;
    public float flashTimer;
    public bool isFlashing;
    public float boolTimer;

    // Start is called before the first frame update
    void Start()
    {
        fear1.GetComponent<SpriteRenderer>().enabled = false;
        fear2.GetComponent<SpriteRenderer>().enabled = false;
        fear3.GetComponent<SpriteRenderer>().enabled = false;
        fear4.GetComponent<SpriteRenderer>().enabled = false;
        fear5.GetComponent<SpriteRenderer>().enabled = false;
        fear6.GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFlashing == true)
        {
            flashTimer += Time.deltaTime;
            boolTimer += Time.deltaTime;
        }
        if (flashTimer >= 0.25)
        {
            fear1.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (fear1.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 0.75)
        {
            fear2.GetComponent<SpriteRenderer>().enabled = true;
            fear1.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (fear2.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.25)
        {
            fear3.GetComponent<SpriteRenderer>().enabled = true;
            fear2.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (fear3.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.75)
        {
            fear4.GetComponent<SpriteRenderer>().enabled = true;
            fear3.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (fear4.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 2.25)
        {
            fear5.GetComponent<SpriteRenderer>().enabled = true;
            fear4.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (fear5.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 2.75)
        {
            fear6.GetComponent<SpriteRenderer>().enabled = true;
            fear5.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (fear6.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 3.15)
        {
            flashTimer -= Time.deltaTime;
            fear6.GetComponent<SpriteRenderer>().enabled = false;
            flashTimer = 0;
        }
        if (boolTimer >= 3.15)
        {
            isFlashing = false;
            boolTimer -= Time.deltaTime;
            boolTimer = 0;
        }
    }
}