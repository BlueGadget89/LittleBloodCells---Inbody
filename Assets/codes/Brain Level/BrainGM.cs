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
            emotion = "Anger";
        }
    }
}
