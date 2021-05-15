using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand_Camera : MonoBehaviour
{
    //This is the vertical size of the camera's field of view
    public float cam0rthsize;
    //This ratio will determine the horizontal camera ratio (aka the orthographic size)
    public float cameraRatio;

    public float xMin, xMax, yMin, yMax;

    public Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = GetComponent<Camera>();
        cam0rthsize = mainCam.orthographicSize;
        cameraRatio = (xMax + cam0rthsize) / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
