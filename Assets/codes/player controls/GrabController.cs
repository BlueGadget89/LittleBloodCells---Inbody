using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public GameObject GP; // Grap point
    public bool onpiece;
    public bool havepiece;

    public AudioClip itemPickUpSound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
        if (havepiece == true)
        {
            GetComponent<AudioSource>().clip = itemPickUpSound;
            GetComponent<AudioSource>().Play();
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
        if (other.gameObject.tag == "pieces" &&!havepiece && onpiece && Input.GetKey(KeyCode.Q))
        {
            other.gameObject.transform.position = GP.transform.position;
            Destroy(other.gameObject.GetComponent<Rigidbody2D>());
            //Destroy(other.gameObject.GetComponent<PolygonCollider2D>());
            other.gameObject.transform.SetParent(GP.transform);
            havepiece = true; 
        }
    }
}
