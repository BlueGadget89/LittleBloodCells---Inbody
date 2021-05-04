using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Damage_Script : MonoBehaviour
{
    public GameObject player;
    public float damagetimer;
    public bool gethit;

    public AudioClip playerDamaged;

    public Color damageColor = Color.cyan;
    public Color originalColor;
    public SpriteRenderer colorRenderer;

    // Start is called before the first frame update
    void Start()
    {
        colorRenderer = player.GetComponent<SpriteRenderer>();
        originalColor = colorRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (gethit)
        {
            Debug.Log("Player took a hit");
            GetComponent<PolygonCollider2D>().enabled = false;
            damagetimer += Time.deltaTime;
            colorRenderer.material.color = damageColor;
        }
        if( damagetimer >= 3)
        {
            GetComponent<PolygonCollider2D>().enabled = true;
            gethit = false;
            damagetimer = 0;
            colorRenderer.material.color = originalColor;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (gethit == false)
        {
            if (collision.gameObject.tag == ("enemy"))
            {
                player.GetComponent<PlayerMovementScript>().playerHp -= 1;
                gethit = true;
                GetComponent<AudioSource>().clip = playerDamaged;
                GetComponent<AudioSource>().PlayOneShot(playerDamaged);
            }
        }   
    }
}
