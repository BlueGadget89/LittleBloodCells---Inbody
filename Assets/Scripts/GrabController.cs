using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController : MonoBehaviour
{
    public Transform grabDetect;
    //public Transform grabDetect1;
    public Transform puzzleHolder;
    public float rayDist;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);
        
        if (grabCheck.collider != null && grabCheck.collider.tag == "Box")
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                grabCheck.collider.gameObject.transform.parent = puzzleHolder;
                grabCheck.collider.gameObject.transform.position = puzzleHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
               
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }
          
        }
    }
}
