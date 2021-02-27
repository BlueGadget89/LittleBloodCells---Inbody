using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtostatue : MonoBehaviour
{
    public Vector3 postion;// poistion on statue
    public float angle; // angle on the statue
    public GameObject statue;
    public GameObject Graper;
    public GameObject pieces;
    // Start is called before the first frame update
    void Start()
    {
        Graper = GameObject.Find("Grap area");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Statue")
        {
            
            Graper.GetComponent<GrabController>().havepiece = false;
            pieces.GetComponent<SpriteRenderer>().enabled = true;
            Destroy(gameObject);
            /*
            gameObject.transform.position = postion;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);
            Destroy(gameObject.GetComponent<PolygonCollider2D>());
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            gameObject.transform.SetParent(statue.transform);
            */
            

        }

    }
}