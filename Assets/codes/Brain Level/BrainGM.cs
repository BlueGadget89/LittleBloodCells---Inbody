using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainGM : MonoBehaviour
{
    public GameObject happyplatform, angerplatform,fearplatfrom;
    public GameObject happyblock, angerblock, fearblock;
    public string emotion;
    public Camera playerCamera, happyCamera, angerCamera, fearCamera;

    // Start is called before the first frame update
    void Start()
    {
        emotion = "Happy";
        happyCamera.GetComponent<Camera>().enabled = true;
        playerCamera.GetComponent<Camera>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
