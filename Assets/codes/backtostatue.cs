using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backtostatue : MonoBehaviour
{
    public Vector3 postion;// poistion on statue
    public float angle; // angle on the statue
    public GameObject statue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "Statue")
        {
            gameObject.transform.position = postion;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);
            Destroy(gameObject.GetComponent<PolygonCollider2D>());
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            gameObject.transform.SetParent(statue.transform);
        }

    }

}