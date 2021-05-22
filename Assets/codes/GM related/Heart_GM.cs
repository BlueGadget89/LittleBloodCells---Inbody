using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart_GM : MonoBehaviour
{
    public string sceneName;

    public GameObject platform1;
    public GameObject platform2;
    public GameObject enemy;
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
        Scene currentScene = SceneManager.GetActiveScene();
        playerWeapon = GameObject.Find("weapon");
        playerWeapon.GetComponent<aiming>().enabled = false;
        Player.GetComponent<PlayerMovementScript>().enabled = false;
        platform1 = GameObject.Find("HeartPuzzlePlatform");
        platform2 = GameObject.Find("HeartPuzzlePlatform2");
        mainCam.GetComponent<Camera>().enabled = true;
        platform1Cam.GetComponent<Camera>().enabled = false;
        platform2Cam.GetComponent<Camera>().enabled = false;
        sceneName = currentScene.name;
        
        spwaner();
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
    void spwaner()
    {
        List<Vector3> enemyspwan = new List<Vector3>();

        {
            if (sceneName == "Hand_Level")
            {
                // spwans pos for enemy
                enemyspwan.Add(new Vector3(-13.29f, 4.26f, 0));
                enemyspwan.Add(new Vector3(-12.23f, -3.0f, 0));
                enemyspwan.Add(new Vector3(-6.158f, -5.991f, 0));
                enemyspwan.Add(new Vector3(5.97f, -5.991f, 0));// needs to turn 180 on Z
                enemyspwan.Add(new Vector3(11.23f, -2.786f, 0));
                enemyspwan.Add(new Vector3(13.3f, 3.98f, 0));

                for (int x = 0; x < enemyspwan.Count; x++)
                {
                    Instantiate(enemy, enemyspwan[x], Quaternion.identity);
                }


            }

            else if (sceneName == "Heart_Level")
            {
                // spwans pos for enemy
                enemyspwan.Add(new Vector3(-1.086519f, 14.19f, 0));
                enemyspwan.Add(new Vector3(11.11f, 14.19f, 0));
                enemyspwan.Add(new Vector3(13.48f, 3.21f, 0));
                enemyspwan.Add(new Vector3(3.3f, 0.47f, 0));// needs to turn 180 on Z

                for (int x = 0; x < enemyspwan.Count; x++)
                {
                    Instantiate(enemy, enemyspwan[x], Quaternion.identity);

                }


            }
        }
    }
}
