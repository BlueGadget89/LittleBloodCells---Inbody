using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabController1 : MonoBehaviour
{
	//bool to check if grabbed is tru/false
	public bool grabbed;
	RaycastHit2D hit;
	//Raycast distance
	public float distance = 12f;
	//the position where teh object would stay
	public Transform holdpoint;	
	public LayerMask notgrabbed;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//press B to grab the object
		if (Input.GetKeyDown(KeyCode.B))
		{

			if (!grabbed)
			{
				Physics2D.queriesStartInColliders = false;

				//raycast for both positions so player can detect if object is left or on right				
				hit = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x, distance);			

				//if player grabs the object and object has the tag "Puzzle" make grabbed = true
				if (hit.collider != null && hit.collider.tag == "Puzzle")
				{
					grabbed = true;

				}
				
			}

			//if B is pressed again let go off item and make grabbed = false
			else if (!Physics2D.OverlapPoint(holdpoint.position, notgrabbed))
			{
				grabbed = false;

				if (hit.collider.gameObject.GetComponent<Rigidbody2D>() != null)
				{
					//hit.collider.gameObject.transform.parent = gameObject.transform;
					hit.collider.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0f;
				}				
			}

		}

		//if the player grabs the object, object shoukd stay at the holder's position
		if (grabbed)
        {
			hit.collider.gameObject.transform.position = holdpoint.position;
		}
			
	}
	//to see the raycast line
	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;

		Gizmos.DrawLine(transform.position, transform.position + Vector3.right * transform.localScale.x * distance);
	}
	
}
