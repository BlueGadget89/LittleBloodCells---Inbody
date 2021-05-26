using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartIndicator2Script : MonoBehaviour
{
    public GameObject heartPlatform2;
    public int pieceIndicated;
    public Vector3 heart7pos;
    public Vector3 heart8pos;
    public Vector3 heart9pos;
    public Vector3 heart10pos;
    public Vector3 heart11pos;
    public Vector3 heart12pos;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        heartPlatform2 = GameObject.Find("HeartPuzzlePlatform2");
    }

    // Update is called once per frame
    void Update()
    {
        pieceIndicated = heartPlatform2.GetComponent<HeartPlatformDetection2>().pieceSelected;

        if (pieceIndicated == 1)
        {
            GetComponent<Transform>().position = new Vector3(heart7pos.x, heart7pos.y, 0);
        }
        if (pieceIndicated == 2)
        {
            GetComponent<Transform>().position = new Vector3(heart8pos.x, heart8pos.y, 0);
        }
        if (pieceIndicated == 3)
        {
            GetComponent<Transform>().position = new Vector3(heart9pos.x, heart9pos.y, 0);
        }
        if (pieceIndicated == 4)
        {
            GetComponent<Transform>().position = new Vector3(heart10pos.x, heart10pos.y, 0);
        }
        if (pieceIndicated == 5)
        {
            GetComponent<Transform>().position = new Vector3(heart11pos.x, heart11pos.y, 0);
        }
        if (pieceIndicated == 6)
        {
            GetComponent<Transform>().position = new Vector3(heart12pos.x, heart12pos.y, 0);
        }
    }
}