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
    public Vector3 spawnPos;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        Graper = GameObject.Find("Grap area");
        gameManager = GameObject.Find("GM");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(gameObject.transform.position.y <= -6.89)
        {
            transform.position = new Vector3(spawnPos.x, spawnPos.y, 0);
        }
        */
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Statue")
        {
            
            Graper.GetComponent<GrabController>().havepiece = false;
            pieces.GetComponent<SpriteRenderer>().enabled = true;
            gameManager.GetComponent<GM>().pieceCount += 1;
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