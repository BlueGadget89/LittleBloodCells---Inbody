using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    
    public GameObject handintro;
    public GameObject heartintro;
    public GameObject brainintro;


   
    public void PlayGame()
    {
        SceneManager.LoadScene("IntroCutscene");
    }
    public void OuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
    public void Handlevel()
    {
        handintro.SetActive(true); 

    }
    public void Handlevelbutton()
    {

        SceneManager.LoadScene("Hand_Level");
    }
}
