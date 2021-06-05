using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GM : MonoBehaviour
{
    public string sceneName;
    public GameObject page2;
    public GameObject tutorialButtonController;

    public GameObject enemy;
    public GameObject Player;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public float sceneChangeTimer; //Timer for changing to the win or lose screens
    public int pieceCount; //counts how many pieces are attached to the statue
    public int enemiesKilled; //counts how many enemies have been defeated
    public int oldPieceCount;
    public AudioSource piecePickUpSource;
    public GameObject GlowingStatuePrefab;
    public Vector3 GlowingStatuePos;


    // Start is called before the first frame update
    void Awake()
    {

    }
    void Start()
    {

        //tutorialButtonController.SetActive = true;
        page2.SetActive(false);
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        //called
        spwaner("Hand_Level");


    }

    // Update is called once per frame
    void Update()
    {

        if (Player.GetComponent<PlayerMovementScript>().playerHp <= 0)
        {
            sceneChangeTimer += Time.deltaTime;
            if (sceneChangeTimer >= 2f)
            {
                SceneManager.LoadScene("HandGameOverScreen");
            }
        }

        if (pieceCount == 6)
        {
            if (enemiesKilled >= 6)
            {
                //This will manage what events occur upon victory.
                //GlowingStatuePrefab.GetComponent<SpriteRenderer>.enabled = true;
                sceneChangeTimer += Time.deltaTime;
                if (sceneChangeTimer >= 2f)
                {
                    SceneManager.LoadScene("Win Screen");
                }
            }
        }
        if (pieceCount > oldPieceCount)
        {
            piecePickUpSource.Play();
            oldPieceCount = pieceCount;
        }
       
    }
    void spwaner(string SceneName)
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
    // use to show player HP
    void heart()
    {
        
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 2)
        {
            Destroy(heart1);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 1)
        {
            Destroy(heart2);
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Destroy(heart3);
        }

    }


}
