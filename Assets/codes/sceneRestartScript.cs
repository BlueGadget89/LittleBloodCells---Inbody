using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneRestartScript : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Scene is reset");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log("Mouse is over reset button");
    }
}
