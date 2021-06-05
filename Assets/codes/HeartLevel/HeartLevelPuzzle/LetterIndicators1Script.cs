using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterIndicators1Script : MonoBehaviour
{
    public GameObject heartCamera;
    public GameObject letterA;
    public GameObject letterD;
    public GameObject mouse;

    Color pressColor = Color.red;
    Color OriginalColorA;
    Color OriginalColorD;
    Color OriginalColorMouse;
    SpriteRenderer ColorRendererA;
    SpriteRenderer ColorRendererD;
    SpriteRenderer ColorRendererMouse;

    // Start is called before the first frame update
    void Start()
    {
        ColorRendererA = letterA.GetComponent<SpriteRenderer>();
        ColorRendererD = letterD.GetComponent<SpriteRenderer>();
        ColorRendererMouse = mouse.GetComponent<SpriteRenderer>();
        OriginalColorA = ColorRendererA.material.color;
        OriginalColorD = ColorRendererD.material.color;
        OriginalColorMouse = ColorRendererMouse.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (heartCamera.GetComponent<Camera>().enabled == false)
        {
            letterA.GetComponent<SpriteRenderer>().enabled = false;
            letterD.GetComponent<SpriteRenderer>().enabled = false;
            mouse.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (heartCamera.GetComponent<Camera>().enabled == true)
        {
            letterA.GetComponent<SpriteRenderer>().enabled = true;
            letterD.GetComponent<SpriteRenderer>().enabled = true;
            mouse.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ColorRendererA.material.color = pressColor;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ColorRendererA.material.color = OriginalColorA;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ColorRendererD.material.color = pressColor;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            ColorRendererD.material.color = OriginalColorD;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Mouse1))
        {
            ColorRendererMouse.material.color = pressColor;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0) || Input.GetKeyUp(KeyCode.Mouse1))
        {
            ColorRendererMouse.material.color = OriginalColorMouse;
        }
    }
}
