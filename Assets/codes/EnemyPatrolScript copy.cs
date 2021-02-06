using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrolScript : MonoBehaviour
{
    //Dictates how fast the entity will move across the platform
    public float speed;
    //Dictate which direction the entity must move once it reaches the edge of the platform
    private bool movingRight = true;

    public Transform groundDetection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is the automatic movement function for the entity.
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        //Sets the origin, direction and length of the raycast detector, respectively to items in parantheses
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        //Tells the item when to switch directions
        if(groundInfo.collider == false)
		{
            if(movingRight == true)
			{
                //Flips the entity around
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
			}
			else
			{
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
		}
    }
}
