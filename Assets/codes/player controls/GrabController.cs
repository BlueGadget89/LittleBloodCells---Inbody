using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{

    public GameObject GP; // Grap point
    public bool onpiece;
    public bool havepiece;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player ");
    }

    // Update is called once per frame
    void Update()
    {
      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pieces")
        {
            onpiece = true;
        }
        if (collision.gameObject.tag == "missingHeartPiece1")
        {
            onpiece = true;
        }
        if (collision.gameObject.tag == "missingHeartPiece2")
        {
            onpiece = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        
            onpiece = false;
        
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "pieces" && (havepiece == false) && (onpiece == true) && Input.GetKey(KeyCode.Q))
        {
            other.gameObject.transform.position = GP.transform.position;
            Destroy(other.gameObject.GetComponent<Rigidbody2D>());
            other.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            //Destroy(other.gameObject.GetComponent<PolygonCollider2D>());
            other.gameObject.transform.SetParent(GP.transform);
            havepiece = true; 
        }
        if (other.gameObject.tag == "pieces" && (havepiece == false) && (onpiece == true))
        {
            Debug.Log("Can pick up piece");
        }
        //Below is stuff to prevent the puzzle breaking on Heart Level
        if (other.gameObject.tag == "missingHeartPiece1" && (havepiece == false) && (onpiece == true) && Input.GetKey(KeyCode.Q))
        {
            other.gameObject.transform.position = GP.transform.position;
            Destroy(other.gameObject.GetComponent<Rigidbody2D>());
            other.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            //Destroy(other.gameObject.GetComponent<PolygonCollider2D>());
            other.gameObject.transform.SetParent(GP.transform);
            havepiece = true;
            Player.GetComponent<PlayerMovementScript>().holdingHeartPiece1 = true;
        }
        if (other.gameObject.tag == "missingHeartPiece2" && (havepiece == false) && (onpiece == true) && Input.GetKey(KeyCode.Q))
        {
            other.gameObject.transform.position = GP.transform.position;
            Destroy(other.gameObject.GetComponent<Rigidbody2D>());
            other.gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
            //Destroy(other.gameObject.GetComponent<PolygonCollider2D>());
            other.gameObject.transform.SetParent(GP.transform);
            havepiece = true;
            Player.GetComponent<PlayerMovementScript>().holdingHeartPiece2 = true;
        }
    }
}
