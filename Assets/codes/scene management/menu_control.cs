using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("LevelSelection");
    }
    public void OuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}
