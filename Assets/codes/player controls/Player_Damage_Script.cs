using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Damage_Script : MonoBehaviour
{
    public GameObject player;
    public float damagetimer;
    public bool gethit;

    public AudioClip playerDamaged;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gethit)
        {
            Debug.Log("Player took a hit");
            GetComponent<PolygonCollider2D>().enabled = false;
            damagetimer += Time.deltaTime;
        }
        if( damagetimer >= 3)
        {
            GetComponent<PolygonCollider2D>().enabled = true;
            gethit = false;
            damagetimer = 0;
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
