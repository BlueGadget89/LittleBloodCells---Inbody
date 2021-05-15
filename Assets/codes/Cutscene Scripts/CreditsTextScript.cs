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
        if (sceneTimer < 26.4)
        {
            sceneTimer += Time.deltaTime;
            GetComponent<Transform>().position += new Vector3(0, 4, 0);
        }
        if (sceneTimer >= 26.4)
        {
            sceneChangeTimer += Time.deltaTime;
        }
        if (sceneChangeTimer >= 3)
        {
            sceneChanging = true;
        }
        if (sceneChanging == true)
        {
            fading.GetComponent<SceneFadeScript>().isTransitioning = true;
        }
        if (sceneChangeTimer >= 6)
        {
            SceneManager.LoadScene("LevelSelection");
        }
    }
}
