using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeHeartDestroy : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.GetComponent<PlayerMovementScript>().playerHp == 0)
        {
            Destroy(gameObject);
        }
    }
}
