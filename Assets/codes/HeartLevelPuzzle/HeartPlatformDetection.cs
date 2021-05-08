using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPlatformDetection : MonoBehaviour
{
    public GameObject Player;
    //public GameObject qButton;
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
    public bool isOnPlatformReady;
    public GameObject GrabArea;
    public GameObject heartIndicator;
    public GameObject playerGun;
    public GameObject gameManager;
    public Camera mainCam, platformCam;

    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    public GameObject restartButton;

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
        GrabArea = GameObject.Find("Grap area");
        heartIndicator = GameObject.Find("HeartIndicator1");
        playerGun = GameObject.Find("weapon");
        gameManager = GameObject.Find("GM");
    }

    // Update is called once per frame
    void Update()
    {
       /* if (gameManager.GetComponent<Heart_GM>().platform1complete == true)
        {
            Player.GetComponent<PlayerMovementScript>().enabled = true;
            playerGun.GetComponent<aiming>().enabled = true;
            GetComponent<HeartPlatformDetection>().enabled = false;
        } */    

        if (isInteracting == true)
        {
            heartIndicator.GetComponent<SpriteRenderer>().enabled = true;
            GrabArea.GetComponent<GrabController>().onpiece = false;

            Player.GetComponent<PlayerMovementScript>().enabled = false;
            playerGun.GetComponent<aiming>().enabled = false;

            mainCam.GetComponent<Camera>().enabled = false;
            platformCam.GetComponent<Camera>().enabled = true;

            health1.GetComponent<SpriteRenderer>().enabled = false;
            health2.GetComponent<SpriteRenderer>().enabled = false;
            health3.GetComponent<SpriteRenderer>().enabled = false;
            restartButton.GetComponent<SpriteRenderer>().enabled = false;

            if (Input.GetKeyDown(KeyCode.Q))
            {
                isInteracting = false;
                Player.GetComponent<PlayerMovementScript>().moveSpeed = 5;
                Player.GetComponent<PlayerMovementScript>().JumpForce = 9;
                Player.GetComponent<PlayerMovementScript>().enabled = true;
                heartIndicator.GetComponent<SpriteRenderer>().enabled = false;
                playerGun.GetComponent<aiming>().enabled = true;
                mainCam.GetComponent<Camera>().enabled = true;
                platformCam.GetComponent<Camera>().enabled = false;

                if (Player.GetComponent<PlayerMovementScript>().playerHp >= 3)
                {
                    health1.GetComponent<SpriteRenderer>().enabled = true;
                }
                health2.GetComponent<SpriteRenderer>().enabled = true;
                health3.GetComponent<SpriteRenderer>().enabled = true;
                restartButton.GetComponent<SpriteRenderer>().enabled = true;
            }
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                GetComponent<AudioSource>().Play();
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                GetComponent<AudioSource>().Play();
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
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece1.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece1.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 2)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece2.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece2.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 3)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece3.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece3.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 4)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece4.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece4.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 5)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece5.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece5.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 6)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece6.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece6.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 360)
            {
                if (heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 0)
                {
                    if (heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 360)
                    {
                        if (heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 0)
                        {
                            if (heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 0)
                            {
                                if (heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 0)
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
                isOnPlatformReady = true;
                //qButton.GetComponent<SpriteRenderer>().enabled = true;
                GrabArea.GetComponent<GrabController>().onpiece = true;
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

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("player"))
        {
            isOnPlatformReady = false;
            //qButton.GetComponent<SpriteRenderer>().enabled = false;
            GrabArea.GetComponent<GrabController>().onpiece = false;
        }
    }
}
