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
    public bool brainLevelComplete;
    public Sprite handSick, heartSick, brainSick;
    public Sprite handHealed, heartHealed, brainHealed;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        handLevelComplete = false;
        heartLevelComplete = false;
        brainLevelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        Scene CurrentScene = SceneManager.GetActiveScene();
        sceneName = CurrentScene.name;

        if (sceneName == "LevelSelection")
        {
            GameObject heartButton = GameObject.Find("heart"), handButton = GameObject.Find("hand"), brainButton = GameObject.Find("brain");
            GameObject heartSilhouette = GameObject.Find("Heart Silhouette"), brainSilhouette = GameObject.Find("Brain Silhouette");
            GameObject heartLocked = GameObject.Find("HeartLocked"), brainLocked = GameObject.Find("BrainLocked");
            
            
            
            if (handLevelComplete == false)
            {
                heartLocked.SetActive(true);
                brainLocked.SetActive(true);
                heartSilhouette.SetActive(false);
                brainSilhouette.SetActive(false);
                heartButton.GetComponent<Button>().interactable = false;
                brainButton.GetComponent<Button>().interactable = false;
                handButton.GetComponent<Image>().sprite = handSick;
            }
            if (handLevelComplete == true)
            {
                heartSilhouette.SetActive(true);
                heartLocked.SetActive(false);

                brainLocked.SetActive(true);
                brainSilhouette.SetActive(false);

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
                brainLocked.SetActive(false);
                brainSilhouette.SetActive(true);
            }
            if (heartLevelComplete == false || handLevelComplete == false)
            {
                brainButton.GetComponent<Button>().interactable = false;
                brainButton.GetComponent<Image>().sprite = brainSick;
            }
            if (heartLevelComplete == true && handLevelComplete == true)
            {
                brainButton.GetComponent<Button>().interactable = true;
            }
            if (brainLevelComplete == true)
            {
                brainButton.GetComponent<Image>().sprite = brainHealed;
            }
            if (heartLevelComplete == true && handLevelComplete == true && brainLevelComplete == true)
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
        if (sceneName == "Brain level")
        {
            Debug.Log("Fuck");
        }
    }
}
