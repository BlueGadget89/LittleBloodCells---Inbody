using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgressTrackerScript : MonoBehaviour
{
    public string sceneName;
    public bool handLevelComplete;
    public bool heartLevelComplete;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        handLevelComplete = false;
        heartLevelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        sceneName = CurrentScene.name;

        if (sceneName == "LevelSelection")
        {
            GameObject heartButton = GameObject.Find("heart");
            if (handLevelComplete == false)
            {
                heartButton.SetActive(false);
            }
            if (handLevelComplete == true)
            {
                heartButton.SetActive(true);
            }
        }

        if (sceneName == "Hand_Level")
        {
            GameObject handGM = GameObject.Find("GM");
            if (handGM.GetComponent<GM>().pieceCount == 6 && handGM.GetComponent<GM>().enemiesKilled == 6)
            {
                handLevelComplete = true;
            }
        }

        if (sceneName == "Heart_Level")
        {
            GameObject heartGM = GameObject.Find("GM");
            if (heartGM.GetComponent<Heart_GM>().platform1complete == true && heartGM.GetComponent<Heart_GM>().platform2complete == true && heartGM.GetComponent<Heart_GM>().enemiesKilled == 4)
            {
                heartLevelComplete = true;
            }
        }
    }
}
