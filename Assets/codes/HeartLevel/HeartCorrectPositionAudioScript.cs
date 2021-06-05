using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCorrectPositionAudioScript : MonoBehaviour
{
    public GameObject heartPiece1;
    public GameObject heartPiece2;
    public GameObject heartPiece3;
    public GameObject heartPiece4;
    public GameObject heartPiece5;
    public GameObject heartPiece6;
    public GameObject heartPiece7;
    public GameObject heartPiece8;
    public GameObject heartPiece9;
    public GameObject heartPiece10;
    public GameObject heartPiece11;
    public GameObject heartPiece12;

    public bool heart1Complete;
    public bool heart2Complete;
    public bool heart3Complete;
    public bool heart4Complete;
    public bool heart5Complete;
    public bool heart6Complete;
    public bool heart7Complete;
    public bool heart8Complete;
    public bool heart9Complete;
    public bool heart10Complete;
    public bool heart11Complete;
    public bool heart12Complete;

    public AudioClip noise;

    // Start is called before the first frame update
    void Start()
    {
        heartPiece1 = GameObject.Find("heart_1_1");
        heartPiece2 = GameObject.Find("heart_1_2");
        heartPiece3 = GameObject.Find("heart_1_3");
        heartPiece4 = GameObject.Find("heart_1_4");
        heartPiece5 = GameObject.Find("heart_1_5");
        heartPiece6 = GameObject.Find("heart_1_6");
        heartPiece7 = GameObject.Find("heart7");
        heartPiece8 = GameObject.Find("heart8");
        heartPiece9 = GameObject.Find("heart9");
        heartPiece10 = GameObject.Find("heart10");
        heartPiece11 = GameObject.Find("heart11");
        heartPiece12 = GameObject.Find("heart12");
    }

    void Update()
    {
        if (heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart1Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart1Complete = true;
                }
            }
        }
        if (heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart2Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart2Complete = true;
                }
            }
        }
        if (heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart3Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart3Complete = true;
                }
            }
        }
        if (heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart4Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart4Complete = true;
                }
            }
        }
        if (heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart5Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart5Complete = true;
                }
            }
        }
        if (heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart6Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart6Complete = true;
                }
            }
        }
        if (heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart7Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart7Complete = true;
                }
            }
        }
        if (heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart8Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart8Complete = true;
                }
            }
        }
        if (heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart9Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart9Complete = true;
                }
            }
        }
        if (heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart10Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart10Complete = true;
                }
            }
        }
        if (heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart11Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart11Complete = true;
                }
            }
        }
        if (heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            if (Input.GetKeyUp(KeyCode.Mouse1) || Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (heart12Complete == false)
                {
                    GetComponent<AudioSource>().PlayOneShot(noise);
                    heart12Complete = true;
                }
            }
        }
    }
}
