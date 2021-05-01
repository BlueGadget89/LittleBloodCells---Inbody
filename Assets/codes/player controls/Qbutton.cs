using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qbutton : MonoBehaviour
{
    public GameObject Graparea;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Graparea.GetComponent<GrabController>().onpiece == true && Graparea.GetComponent<GrabController>().havepiece == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true; 
        }
        
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
