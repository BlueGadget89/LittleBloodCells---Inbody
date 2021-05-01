using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPuzzlePieces : MonoBehaviour
{
    //To detect if the player is interacting with the puzzle pieces
    //public bool playerInteracting;
    public GameObject Player;
    public float angle;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player ");
    }

    // Update is called once per frame
    void Update()
    {
        //This changes the z rotation value under transform to whatever value angle is set to
        //by the HeartPlatformDetection script
        GetComponent<Transform>().rotation = Quaternion.Euler(0, 0, angle);
    }
}
