using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TwoHeartDestroy : MonoBehaviour
{
    public GameObject Player;
    public GameObject playerDamageDetector;
    //Stuff for damage indicator
    Color damageColor = Color.red;
    Color OriginalColor;
    SpriteRenderer ColorRenderer;
    public string sceneName;
    public Image brainLevelColorRenderer;

    //public GameObject heartPlatform1;
    //public GameObject heartPlatform2;
    // Start is called before the first frame update
    void Start()
    {
        if (sceneName == "Hand_Level" || sceneName == "Heart_Level")
        {
            ColorRenderer = GetComponent<SpriteRenderer>();
            OriginalColor = ColorRenderer.material.color;
        }
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Brain level")
        {
            brainLevelColorRenderer = GetComponent<Image>();
            OriginalColor = brainLevelColorRenderer.material.color;
        }
        /*
        if (sceneName == "Heart_Level")
        {
            heartPlatform1 = GameObject.Find("HeartPuzzlePlatform");
            heartPlatform2 = GameObject.Find("HeartPuzzlePlatform2");
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneName == "Hand_Level" || sceneName == "Heart_Level")
        {
            if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == true)
            {
                ColorRenderer.material.color = damageColor;
            }
            if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == false)
            {
                ColorRenderer.material.color = OriginalColor;
            }
            if (Player.GetComponent<PlayerMovementScript>().playerHp == 1)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
        if (sceneName == "Brain level")
        {
            if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == true)
            {
                brainLevelColorRenderer.material.color = damageColor;
            }
            if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == false)
            {
                brainLevelColorRenderer.material.color = OriginalColor;
            }
            if (Player.GetComponent<PlayerMovementScript>().playerHp == 1)
            {
                Destroy(gameObject);
            }
        }
        /*
        if (sceneName == "Heart_Level")
        {
            if (heartPlatform1.GetComponent<HeartPlatformDetection>().isInteracting == true || heartPlatform2.GetComponent<HeartPlatformDetection2>().isInteracting == true)
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            if (heartPlatform2.GetComponent<HeartPlatformDetection2>().isInteracting == false || heartPlatform1.GetComponent<HeartPlatformDetection>().isInteracting == false)
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
        }
        */
    }
}
