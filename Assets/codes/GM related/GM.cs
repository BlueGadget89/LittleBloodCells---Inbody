using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GM : MonoBehaviour
{
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


    // Start is called before the first frame update
    void Awake()
    {

    }
    void Start()
    {
        //tutorialButtonController.SetActive = true;
        page2.SetActive(false);
        spwaner();
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
    void spwaner()
    {
        // spwans pos for enemy
        Vector3 Sp1 = new Vector3(-13.29f, 4.26f, 0);
        Vector3 Sp2 = new Vector3(-12.23f, -3.0f, 0);
        Vector3 Sp3 = new Vector3(-6.158f, -5.991f, 0);
        Vector3 Sp4 = new Vector3(5.97f, -5.991f, 0);// needs to turn 180 on Z
        Vector3 Sp5 = new Vector3(11.23f, -2.786f, 0);
        Vector3 Sp6 = new Vector3(13.3f, 3.98f, 0);

        // spwaning enemys
        Instantiate(enemy, Sp1, Quaternion.identity);
        Instantiate(enemy, Sp2, Quaternion.identity);
        Instantiate(enemy, Sp3, Quaternion.identity);
        Instantiate(enemy, Sp4, Quaternion.identity);
        Instantiate(enemy, Sp5, Quaternion.identity);
        Instantiate(enemy, Sp6, Quaternion.identity);


    }
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
