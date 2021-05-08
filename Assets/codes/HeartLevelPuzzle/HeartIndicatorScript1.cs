using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartIndicatorScript1 : MonoBehaviour
{
    public GameObject heartPlatform1;
    public int pieceIndicated;
    public Vector3 heart1pos;
    public Vector3 heart2pos;
    public Vector3 heart3pos;
    public Vector3 heart4pos;
    public Vector3 heart5pos;
    public Vector3 heart6pos;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        heartPlatform1 = GameObject.Find("HeartPuzzlePlatform");
    }

    // Update is called once per frame
    void Update()
    {
        pieceIndicated = heartPlatform1.GetComponent<HeartPlatformDetection>().pieceSelected;

        if (pieceIndicated == 1)
        {
            GetComponent<Transform>().position = new Vector3(heart1pos.x, heart1pos.y, 0);
        }
        if (pieceIndicated == 2)
        {
            GetComponent<Transform>().position = new Vector3(heart2pos.x, heart2pos.y, 0);
        }
        if (pieceIndicated == 3)
        {
            GetComponent<Transform>().position = new Vector3(heart3pos.x, heart3pos.y, 0);
        }
        if (pieceIndicated == 4)
        {
            GetComponent<Transform>().position = new Vector3(heart4pos.x, heart4pos.y, 0);
        }
        if (pieceIndicated == 5)
        {
            GetComponent<Transform>().position = new Vector3(heart5pos.x, heart5pos.y, 0);
        }
        if (pieceIndicated == 6)
        {
            GetComponent<Transform>().position = new Vector3(heart6pos.x, heart6pos.y, 0);
        }
    }
}
