using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPlatformDetection2 : MonoBehaviour
{
    public GameObject Player;
    //public GameObject qButton;
    public bool isInteracting;
    public GameObject heartPiece7;
    public GameObject heartPiece8;
    public GameObject heartPiece9;
    public GameObject heartPiece10;
    public GameObject heartPiece11;
    public GameObject heartPiece12;
    public int pieceSelected;
    public bool missingPieceAdded;
    public bool piecesComplete;
    public bool isOnPlatformReady;
    public GameObject GrabArea;
    public GameObject heartIndicator;
    public GameObject playerGun;
    public GameObject gameManager;
    public Camera mainCam, platformCam;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player ");
        heartPiece7 = GameObject.Find("heart7");
        heartPiece8 = GameObject.Find("heart8");
        heartPiece9 = GameObject.Find("heart9");
        heartPiece10 = GameObject.Find("heart10");
        heartPiece11 = GameObject.Find("heart11");
        heartPiece12 = GameObject.Find("heart12");
        missingPieceAdded = false;
        GrabArea = GameObject.Find("Grap area");
        heartIndicator = GameObject.Find("HeartIndicator2");
        heartIndicator.GetComponent<SpriteRenderer>().enabled = false;
        playerGun = GameObject.Find("weapon");
        gameManager = GameObject.Find("GM");
    }

    // Update is called once per frame
    void Update()
    {
       /* if (gameManager.GetComponent<Heart_GM>().platform2complete == true)
        {
            Player.GetComponent<PlayerMovementScript>().enabled = true;
            playerGun.GetComponent<aiming>().enabled = true;
            GetComponent<HeartPlatformDetection2>().enabled = false;
        }
        */

        if (isInteracting == true)
        {
            heartIndicator.GetComponent<SpriteRenderer>().enabled = true;
            GrabArea.GetComponent<GrabController>().onpiece = false;

            Player.GetComponent<PlayerMovementScript>().enabled = false;
            playerGun.GetComponent<aiming>().enabled = false;

            mainCam.GetComponent<Camera>().enabled = false;
            platformCam.GetComponent<Camera>().enabled = true;

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
                    heartPiece7.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece7.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 2)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece8.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece8.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 3)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece9.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece9.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 4)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece10.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece10.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 5)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece11.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece11.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (pieceSelected == 6)
            {
                if (Input.GetKeyDown(KeyCode.Mouse0))
                {
                    heartPiece12.GetComponent<HeartPuzzlePieces>().angle += 45;
                }
                if (Input.GetKeyDown(KeyCode.Mouse1))
                {
                    heartPiece12.GetComponent<HeartPuzzlePieces>().angle -= 45;
                }
            }
            if (heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 360)
            {
                if (heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 0)
                {
                    if (heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 360)
                    {
                        if (heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 0)
                        {
                            if (heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 0)
                            {
                                if (heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 360 || heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 0)
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
                    heartPiece7.GetComponent<SpriteRenderer>().enabled = true;
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

