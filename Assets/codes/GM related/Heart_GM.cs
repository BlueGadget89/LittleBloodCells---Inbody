using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_GM : MonoBehaviour
{
    public GameObject platform1;
    public GameObject platform2;
    public bool platform1complete;
    public bool platform2complete;

    // Start is called before the first frame update
    void Start()
    {
        platform1 = GameObject.Find("HeartPuzzlePlatform");
        platform2 = GameObject.Find("HeartPuzzlePlatform2");
    }

    // Update is called once per frame
    void Update()
    {
        if (platform1.GetComponent<HeartPlatformDetection>().piecesComplete == true)
        {
            platform1complete = true;
        }
        if (platform2.GetComponent<HeartPlatformDetection2>().piecesComplete == true)
        {
            platform2complete = true;
        }
    }
}
