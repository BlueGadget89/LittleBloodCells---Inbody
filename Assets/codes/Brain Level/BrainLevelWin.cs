using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrainLevelWin : MonoBehaviour
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
            SceneManager.LoadScene("OutroCutscene");
        }
    }
    private void OnMouseEnter()
    {
        Debug.Log("Mouse is over returm button");
    }
}
