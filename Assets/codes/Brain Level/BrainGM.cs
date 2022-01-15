using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public int enemiesKilled;
    public bool levelComplete;
    public float sceneTransitionTimer;
    public float loseTransitionTimer;

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
        levelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        playerPositionTracker.GetComponent<Transform>().position = player.GetComponent<Transform>().position;
        playerPos = playerPositionTracker.GetComponent<Transform>().position;

        if (player.GetComponent<PlayerMovementScript>().playerHp <= 0)
        {
            Debug.Log("Level Lost");
            loseTransitionTimer += Time.deltaTime;
        }
        if (loseTransitionTimer >= 3)
        {
            SceneManager.LoadScene("BrainLevelLose");
        }
        
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
            happyCamera.GetComponent<Camera>().enabled = false;
            playerCamera.GetComponent<Camera>().enabled = true;
        }
        if (playerPositionTracker.GetComponent<Transform>().position.x >= 15 && playerPositionTracker.GetComponent<Transform>().position.x <= 57.32 && emotionGM.GetComponent<BrainPuzzle>().angerComplete == false)
        {
            playerCamera.GetComponent<Camera>().enabled = false;
            angerCamera.GetComponent<Camera>().enabled = true;
            player.GetComponent<PlayerMovementScript>().Spwan = new Vector3(20, 3, 0);
        }
        if (emotionGM.GetComponent<BrainPuzzle>().angerComplete == true)
        {
            Debug.Log("anger complete");
            fearblock.GetComponent<BoxCollider2D>().enabled = false;
            emotion = "Fear";
            angerplatform.GetComponent<SpriteRenderer>().enabled = true;
            angerplatform.GetComponent<PolygonCollider2D>().enabled = true;
            angerCamera.GetComponent<Camera>().enabled = false;
            playerCamera.GetComponent<Camera>().enabled = true;
        }
        if (playerPositionTracker.GetComponent<Transform>().position.x >= 63)
        {
            playerCamera.GetComponent<Camera>().enabled = false;
            fearCamera.GetComponent<Camera>().enabled = true;
            player.GetComponent<PlayerMovementScript>().Spwan = new Vector3(68, 2, 0);
        }
        if (emotionGM.GetComponent<BrainPuzzle>().happyComplete == true && emotionGM.GetComponent<BrainPuzzle>().angerComplete == true && emotionGM.GetComponent<BrainPuzzle>().fearComplete == true)
        {
            levelComplete = true;
            sceneTransitionTimer += Time.deltaTime;
        }
        if (sceneTransitionTimer >= 3)
        {
            SceneManager.LoadScene("BrainLevelWin");
        }
    }
}
