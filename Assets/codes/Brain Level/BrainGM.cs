using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainGM : MonoBehaviour
{
    public GameObject happyplatform, angerplatform,fearplatfrom;
    public GameObject happyblock, angerblock, fearblock;
    public string emotion;
    public Camera playerCamera, happyCamera, angerCamera, fearCamera;
    public GameObject emotionGM;
    public GameObject player;
    public GameObject playerPositionTracker;
    public Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        emotion = "Happy";
        happyCamera.GetComponent<Camera>().enabled = true;
        playerCamera.GetComponent<Camera>().enabled = false;
        angerCamera.GetComponent<Camera>().enabled = false;
        fearCamera.GetComponent<Camera>().enabled = false;
        happyplatform.GetComponent<SpriteRenderer>().enabled = false;
        happyplatform.GetComponent<PolygonCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPositionTracker.GetComponent<Transform>().position = player.GetComponent<Transform>().position;
        playerPos = playerPositionTracker.GetComponent<Transform>().position;
        
        /*
        if (playerPos.x >= -32.11 && playerPos.x <= 8.06 && player.transform.IsChildOf(transform) == false)
        {
            happyCamera.GetComponent<Camera>().enabled = true;
            playerCamera.GetComponent<Camera>().enabled = false;
            angerCamera.GetComponent<Camera>().enabled = false;
            Debug.Log("Player is in the happy puzzle");
        }
        */
        if (emotionGM.GetComponent<BrainPuzzle>().happyComplete == true)
        {
            Debug.Log("happy complete");
            angerblock.GetComponent<BoxCollider2D>().enabled = false;
            emotion = "Anger";
            happyplatform.GetComponent<SpriteRenderer>().enabled = true;
            happyplatform.GetComponent<PolygonCollider2D>().enabled = true;
        }
        if (playerPositionTracker.GetComponent<Transform>().position.x >= 14.84 && playerPositionTracker.GetComponent<Transform>().position.x <= 57.32 && emotionGM.GetComponent<BrainPuzzle>().angerComplete == false)
        {
            playerCamera.GetComponent<Camera>().enabled = false;
            angerCamera.GetComponent<Camera>().enabled = true;
            happyCamera.GetComponent<Camera>().enabled = false;
            player.GetComponent<PlayerMovementScript>().Spwan = new Vector3(20, 3, 0);
        }
        if (emotionGM.GetComponent<BrainPuzzle>().angerComplete == true)
        {
            angerCamera.GetComponent<Camera>().enabled = false;
            fearCamera.GetComponent<Camera>().enabled = true;
            Debug.Log("anger complete");
            angerblock.GetComponent<BoxCollider2D>().enabled = false;
            emotion = "Fear";
            angerplatform.GetComponent<SpriteRenderer>().enabled = true;
            angerplatform.GetComponent<PolygonCollider2D>().enabled = true;
        }
    }
}
