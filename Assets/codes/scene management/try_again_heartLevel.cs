using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class try_again_heartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Debug.Log("Scene is reset");
            SceneManager.LoadScene("Heart_Level");
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log("Mouse is over try again button");
    }
}
