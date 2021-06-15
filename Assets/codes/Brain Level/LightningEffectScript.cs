using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningEffectScript : MonoBehaviour
{
    public GameObject playerDamageDetector;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<AudioSource>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == true)
        {
            GetComponent<AudioSource>().enabled = true;
            GetComponent<SpriteRenderer>().enabled = true;
            //GetComponent<AudioSource>().Play();
            //StartCoroutine(soundEffect());
        }
        if (playerDamageDetector.GetComponent<Player_Damage_Script>().gethit == false)
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<AudioSource>().enabled = false;
        }
    }

    public IEnumerator soundEffect()
    {
        //GetComponent<AudioSource>().Play();
        yield return null;
    }
}
