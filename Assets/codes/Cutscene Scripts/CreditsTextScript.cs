using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsTextScript : MonoBehaviour
{

    public float sceneTimer;
    public float sceneChangeTimer;
    public bool sceneChanging;
    public GameObject fading;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (sceneTimer < 27)
        {
            sceneTimer += Time.deltaTime;
            //GetComponent<Transform>().position += new Vector3(0, 4, 0);
        }
        if (sceneTimer >= 27)
        {
            sceneChangeTimer += Time.deltaTime;
        }
        if (sceneChangeTimer >= 5)
        {
            sceneChanging = true;
        }
        if (sceneChanging == true)
        {
            fading.GetComponent<SceneFadeScript>().running2 = true;
            fading.SetActive(true);
            fading.GetComponent<SceneFadeScript>().isTransitioning = true;
        }
        if (sceneChangeTimer >= 8)
        {
            SceneManager.LoadScene("LevelSelection");
        }
    }
}
