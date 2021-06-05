using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelProgressTrackerScript : MonoBehaviour
{
    public string sceneName;
    public bool handLevelComplete;
    public bool heartLevelComplete;
    public Sprite handSick, heartSick, brainSick;
    public Sprite handHealed, heartHealed, brainHealed;

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
            GameObject heartSilhouette = GameObject.Find("Heart Silhouette");
            GameObject heartLocked = GameObject.Find("HeartLocked");
            GameObject handButton = GameObject.Find("hand");
            GameObject brainButton = GameObject.Find("brain");
            if (handLevelComplete == false)
            {
                heartLocked.SetActive(true);
                heartSilhouette.SetActive(false);
                heartButton.GetComponent<Button>().interactable = false;
                handButton.GetComponent<Image>().sprite = handSick;
            }
            if (handLevelComplete == true)
            {
                heartSilhouette.SetActive(true);
                heartLocked.SetActive(false);
                heartButton.GetComponent<Button>().interactable = true;
                handButton.GetComponent<Image>().sprite = handHealed;
            }
            if (heartLevelComplete == false)
            {
                heartButton.GetComponent<Image>().sprite = heartSick;
            }
            if (heartLevelComplete == true)
            {
                heartButton.GetComponent<Image>().sprite = heartHealed;
            }
            if (heartLevelComplete == false && handLevelComplete == false)
            {
                brainButton.GetComponent<Button>().interactable = false;
            }
            if (heartLevelComplete == true && handLevelComplete == true)
            {
                Debug.Log("Game done");
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
