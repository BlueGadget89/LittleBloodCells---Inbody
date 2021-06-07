using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HappyItemFlashScript : MonoBehaviour
{
    public GameObject happy1, happy2, happy3, happy4;
    public float flashTimer;
    public bool isFlashing;
    public float boolTimer;

    // Start is called before the first frame update
    void Start()
    {
        happy1.GetComponent<SpriteRenderer>().enabled = false;
        happy2.GetComponent<SpriteRenderer>().enabled = false;
        happy3.GetComponent<SpriteRenderer>().enabled = false;
        happy4.GetComponent<SpriteRenderer>().enabled = false;
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
            happy1.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (happy1.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 0.75)
        {
            happy2.GetComponent<SpriteRenderer>().enabled = true;
            happy1.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (happy2.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.25)
        {
            happy3.GetComponent<SpriteRenderer>().enabled = true;
            happy2.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (happy3.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 1.75)
        {
            happy4.GetComponent<SpriteRenderer>().enabled = true;
            happy3.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (happy4.GetComponent<SpriteRenderer>().enabled == true && flashTimer >= 2.25)
        {
            flashTimer -= Time.deltaTime;
            happy4.GetComponent<SpriteRenderer>().enabled = false;
            flashTimer = 0;
        }
        if (boolTimer >= 2.25)
        {
            isFlashing = false;
            boolTimer -= Time.deltaTime;
            boolTimer = 0;
        }
    }
}
