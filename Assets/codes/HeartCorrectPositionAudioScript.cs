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

    // Update is called once per frame
    void Update()
    {
        if (heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece1.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece2.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece3.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece4.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece5.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece6.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece7.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece8.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece9.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece10.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece11.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
        if (heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 0 || heartPiece12.GetComponent<HeartPuzzlePieces>().angle == 360)
        {
            GetComponent<AudioSource>().PlayOneShot(noise);
        }
    }
}
