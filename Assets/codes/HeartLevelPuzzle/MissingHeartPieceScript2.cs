using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissingHeartPieceScript2 : MonoBehaviour
{
    public bool isOnPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        isOnPuzzle = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOnPuzzle == true)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<PolygonCollider2D>().enabled = false;
            //GetComponent<Rigidbody2D>().simulated = false;
        }
    }
}
