using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeHeartDestroy : MonoBehaviour
{
    public GameObject Player;
    public GameObject playerDamageDetector;
    //Stuff for damage indicator
    Color damageColor = Color.cyan;
    Color OriginalColor;
    SpriteRenderer ColorRenderer;
    // Start is called before the first frame update
    void Start()
    {
        ColorRenderer = GetComponent<SpriteRenderer>();
        OriginalColor = ColorRenderer.material.color;
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
    }
}
