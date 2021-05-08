using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCameraScript : MonoBehaviour
{
    public Transform followTransform;
    public BoxCollider2D mapBounds;

    //All of below is pulled from this article: generalistprogrammer.com/unity/unity-2d-how-to-make-camera-follow-player/
    //minimum and maximum x and y values to set boundaries
    public float xMin, xMax, yMin, yMax;
    //We set these as the x and y values for the camera position
    public float camY, camX;
    //This is the vertical size of the camera's field of view
    public float cam0rthsize;
    //This ratio will determine the horizontal camera ratio (aka the orthographic size)
    public float cameraRatio;

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
        camY = Mathf.Clamp(followTransform.position.y, yMin + cam0rthsize, yMax - cam0rthsize);
        camX = Mathf.Clamp(followTransform.position.x, xMin + cam0rthsize, xMax - cam0rthsize);

        this.transform.position = new Vector3(camX, camY, this.transform.position.z);
    }
}
