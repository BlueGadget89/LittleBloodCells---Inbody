using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeHeartDestroy : MonoBehaviour
{
    public GameObject Player;
    public GameObject playerDamageDetector;
    //Stuff for damage indicator
    Color damageColor = Color.cyan;
    Color OriginalColor;
    SpriteRenderer ColorRenderer;
    public string sceneName;

    public GameObject heartPlatform1;
    public GameObject heartPlatform2;

    // Start is called before the first frame update
    void Start()
    {
        ColorRenderer = GetComponent<SpriteRenderer>();
        OriginalColor = ColorRenderer.material.color;
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Heart_Level")
        {
            heartPlatform1 = GameObject.Find("HeartPuzzlePlatform");
            heartPlatform2 = GameObject.Find("HeartPuzzlePlatform2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == true)
        {
            ColorRenderer.material.color = damageColor;
        }
        if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == false)
        {
            ColorRenderer.material.color = OriginalColor;
        }
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Destroy(gameObject);
        }
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
    }
}
