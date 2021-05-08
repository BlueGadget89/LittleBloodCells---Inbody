using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart_GM : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public bool platform1complete;
    public bool platform2complete;

    public GameObject Player;
    public GameObject playerWeapon;
    public int enemiesKilled;
    public float totalEnemies;

    public Camera mainCam, platform1Cam, platform2Cam;

    public float winTimer;
    public float loseTimer;

    // Start is called before the first frame update
    void Start()
    {
        playerWeapon = GameObject.Find("weapon");
        playerWeapon.GetComponent<aiming>().enabled = false;
        Player.GetComponent<PlayerMovementScript>().enabled = false;
        platform1 = GameObject.Find("HeartPuzzlePlatform");
        platform2 = GameObject.Find("HeartPuzzlePlatform2");
        mainCam.GetComponent<Camera>().enabled = true;
        platform1Cam.GetComponent<Camera>().enabled = false;
        platform2Cam.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (platform1.GetComponent<HeartPlatformDetection>().piecesComplete == true)
        {
            platform1complete = true;
        }
        if (platform2.GetComponent<HeartPlatformDetection2>().piecesComplete == true)
        {
            platform2complete = true;
        }

        if (platform1complete == true)
        {
            if (platform2complete == true)
            {
                if (enemiesKilled == totalEnemies)
                {
                    Debug.Log("Heart Level Complete");
                    winTimer += Time.deltaTime;
                }
            }
        }
        if (winTimer >= 3)
        {
            SceneManager.LoadScene("Heart_Victory");
        }

        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Debug.Log("Heart Level Lost");
            loseTimer += Time.deltaTime;
        }
        if (loseTimer >= 3)
        {
            SceneManager.LoadScene("HandGameOverScreen");
        }

    }
}
