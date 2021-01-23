using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public Rigidbody rb;
    public float pickUpRange;
    public float dropforwardforce, dropupwardforce;
    public bool equipped;
    public static bool slotfull;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    private void Update()
    {
        Vector3 distanceToPlayer = player.position - transform.position;
        if (!equipped && distanceToPlayer.magnitude <= pickUpRange && Input.GetKeyDown(KeyCode.E) && !slotfull) PickUp();

    }
    
    private void PickUp()
    {

    }

    private void Drop()
    {

    }
}
