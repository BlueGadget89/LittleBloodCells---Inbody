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
        /*//press G to grab
        if (Input.GetKeyDown(KeyCode.G))
        {
            //cast ray to check for hits
            RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.forward, Vector2.right * transform.localScale, rayDist);

            if (grabCheck.collider != null && grabCheck.collider.tag == "Puzzle")
            {
                grabCheck.collider.gameObject.transform.parent = puzzleHolder;
                grabCheck.collider.gameObject.transform.position = puzzleHolder.position;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
             
            }

            //press F to drop puzzle
            if (Input.GetKeyDown(KeyCode.F))
            {               
                 grabCheck.collider.gameObject.transform.parent = null;
                 grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;                                   
            }
        */

        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale.x, rayDist);

        //the player detetcts the puzzle
        if (grabCheck.collider != null && grabCheck.collider.tag == "Puzzle")
        {
            //presses G to grab puzzle
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
