using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPlatformDetection : MonoBehaviour
{
    public GameObject Player;
    public bool isInteracting;
    public GameObject heartPiece1;
    public GameObject heartPiece2;
    public GameObject heartPiece3;
    public GameObject heartPiece4;
    public GameObject heartPiece5;
    public GameObject heartPiece6;
    public int pieceSelected;
    public bool missingPieceAdded;
    public bool piecesComplete;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player ");
        heartPiece1 = GameObject.Find("heart_1_1");
        heartPiece2 = GameObject.Find("heart_1_2");
        heartPiece3 = GameObject.Find("heart_1_3");
        heartPiece4 = GameObject.Find("heart_1_4");
        heartPiece5 = GameObject.Find("heart_1_5");
        heartPiece6 = GameObject.Find("heart_1_6");
        heartPiece1.GetComponent<SpriteRenderer>().enabled = false;
        missingPieceAdded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInteracting == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                isInteracting = false;
                Player.GetComponent<PlayerMovementScript>().moveSpeed = 5;
                Player.GetComponent<PlayerMovementScript>().JumpForce = 9;
                //Player.GetComponent<PlayerMovementScript>().enabled = true;
            }
            //The Following is going to be all code for moving the pieces, lots of copy pasting
            if (pieceSelected >= 7)
            {
                pieceSelected = 1;
            }
            if (pieceSelected <= 0)
            {
                pieceSelected = 6;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                pieceSelected -= 1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                pieceSelected += 1;
            }
            if (pieceSelected == 1)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece1.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece1.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 2)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece2.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece2.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 3)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece3.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece3.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 4)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece4.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece4.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 5)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece5.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece5.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 6)
            {
                if (Input.GetKeyDown(KeyCode.W))
                {
                    heartPiece6.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    heartPiece6.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 0)
            {
                if (heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 360)
                {
                    if (heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 0)
                    {
                        if (heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 360)
                        {
                            if (heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 360)
                            {
                                if (heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 360)
                                {
                                    piecesComplete = true;
                                }
                            }
                        }
                    }
                }
            }
        }


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("player"))
        {
            Debug.Log("Player is on platform");
            if (missingPieceAdded == true)
            {
                if (Input.GetKeyUp(KeyCode.Q))
                {
                    isInteracting = true;
                    heartPiece1.GetComponent<SpriteRenderer>().enabled = true;
                    Player.GetComponent<PlayerMovementScript>().moveSpeed = 0;
                    Player.GetComponent<PlayerMovementScript>().JumpForce = 0;
                    //Player.GetComponent<PlayerMovementScript>().enabled = false;
                }
            }
        }
    }
}
