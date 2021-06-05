using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartPieceDetectionScript2 : MonoBehaviour
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
        heartPlatform = GameObject.Find("HeartPuzzlePlatform2");
        Player = GameObject.Find("player ");
        hiddenHeartPiece = GameObject.Find("heart9");
        missingHeartPiece = GameObject.Find("MissingHeartPiece2");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("q");
        if (GrabArea.GetComponent<GrabController>().havepiece == true)
        {
            Debug.Log("h");
            if (collision.gameObject.tag == "player")
            {
                Debug.Log("piece has arrived");
                missingHeartPiece.GetComponent<MissingHeartPieceScript2>().isOnPuzzle = true;
                heartPlatform.GetComponent<HeartPlatformDetection2>().missingPieceAdded = true;
                GrabArea.GetComponent<GrabController>().havepiece = false;
                hiddenHeartPiece.GetComponent<hiddenHeartPieceScript>().onPuzzle = true;
            }
        }
    }
}