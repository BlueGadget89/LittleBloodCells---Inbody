using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiddenHeartPieceScript : MonoBehaviour
{
    public bool onPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (onPuzzle == true)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
