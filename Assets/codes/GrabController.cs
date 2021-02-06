using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public GameObject GP; // Grap point
    public bool onpiece;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (onpiece && Input.GetKey(KeyCode.E))
        {
            Debug.Log("hit");
            
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "pieces")
        {
            onpiece = true;
        }
        else
        {
            onpiece = false;
        }
        if (onpiece && Input.GetKey(KeyCode.Q))
        {
            Debug.Log("ontrigger");

        }

    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (onpiece && Input.GetKey(KeyCode.Q))
        {
            other.gameObject.transform.position = GP.transform.position;
            other.gameObject.transform.SetParent(GP.transform);
        }
    }
}
