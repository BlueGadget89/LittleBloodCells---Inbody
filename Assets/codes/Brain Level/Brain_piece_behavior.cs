using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain_piece_behavior : MonoBehaviour
{
    public GameObject emotionGM;
    public GameObject brainGM;
    public bool onhit;
    public SpriteRenderer colorRenderer;
    public Color regularColor;
    public Color noHitColor;
    public int contactOrderListPlace;

    // Start is called before the first frame update
    void Start()
    {
        brainGM = GameObject.Find("GM");
        onhit = false;
        //colorRenderer = GetComponent<SpriteRenderer>();
        //regularColor = colorRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        //noHitColor = new Color(100, 100, 100, 255);
        if (brainGM.GetComponent<BrainGM>().emotion == "Happy")
        {

        }
        if (onhit == true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = regularColor;// change color
        }
        if(onhit == false)
        {
            gameObject.GetComponent<SpriteRenderer>().color = noHitColor; // change color
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            Debug.Log("Bullet hit piece");
            onhit = true;
            Destroy(collision.gameObject);
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().simulated = false;
            emotionGM.GetComponent<BrainPuzzle>().contactOrder.Add(contactOrderListPlace);
        }
    }
}
