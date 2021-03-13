using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Hand_Level");
    }
    public void OuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
