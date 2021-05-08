using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Qbutton : MonoBehaviour
{
    public GameObject Graparea;
    public GameObject player;

    public SpriteRenderer spriteRenderer;
    public Sprite handSprite;
    public Sprite heartSprite;

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        //This helps the script detect what the current scene is
        Scene currentScene = SceneManager.GetActiveScene();

        //This sets a string to have the name of the current scene as it's text
        sceneName = currentScene.name;

        //These if statements are self explanatory
        if (sceneName == "Hand_Level")
        {
            GetComponent<SpriteRenderer>().sprite = handSprite;
        }
        if (sceneName == "Heart_Level")
        {
            GetComponent<SpriteRenderer>().sprite = heartSprite;
        }
        if (sceneName == "HeartLevelProto")
        {
            GetComponent<SpriteRenderer>().sprite = heartSprite;
            //this is just for testing on the prototype
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Graparea.GetComponent<GrabController>().onpiece == true && Graparea.GetComponent<GrabController>().havepiece == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true; 
        }
        
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
        
    }
}
