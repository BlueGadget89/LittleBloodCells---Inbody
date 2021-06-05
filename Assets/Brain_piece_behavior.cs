using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain_piece_behavior : MonoBehaviour
{
    public GameObject emotionGM;
    public bool onhit;
    // Start is called before the first frame update
    void Start()
    {
        onhit = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (onhit == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, 100);// change color
        }
        if(onhit == false)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(100, 100, 100, 100); // change color
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            onhit = true;
            Destroy(collision.gameObject);
        }
    }
}
