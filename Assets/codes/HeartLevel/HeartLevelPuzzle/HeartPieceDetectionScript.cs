using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPieceDetectionScript : MonoBehaviour
{
    public GameObject GrabArea;
    public GameObject heartPlatform;
    public GameObject Player;
    public GameObject missingHeartPiece;
    public GameObject hiddenHeartPiece;

    // Start is called before the first frame update
    void Start()
    {
        GrabArea = GameObject.Find("Grap area");
        heartPlatform = GameObject.Find("HeartPuzzlePlatform");
        Player = GameObject.Find("player ");
        hiddenHeartPiece = GameObject.Find("heart_1_1");
        missingHeartPiece = GameObject.Find("MissingHeartPiece");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (GrabArea.GetComponent<GrabController>().havepiece == true)
        {
            if (collision.gameObject.tag == "player")
            {
                if (Player.GetComponent<PlayerMovementScript>().holdingHeartPiece1 == true)
                {
                    missingHeartPiece.GetComponent<missingHeartPieceScript>().isOnPuzzle = true;
                    heartPlatform.GetComponent<HeartPlatformDetection>().missingPieceAdded = true;
                    GrabArea.GetComponent<GrabController>().havepiece = false;
                    hiddenHeartPiece.GetComponent<hiddenHeartPieceScript>().onPuzzle = true;
                    Player.GetComponent<PlayerMovementScript>().holdingHeartPiece1 = false;
                }
            }
        }
    }
}
