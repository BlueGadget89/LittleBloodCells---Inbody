using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_control : MonoBehaviour
{
    
    public GameObject handintro;
    public GameObject heartintro;
    public GameObject brainintro;
    public GameObject levelSelectText;
    public GameObject heartSilhouette, handSilhouette, heartLocked;
    public GameObject sceneTransition;

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
        heartintro.SetActive(false);
        handintro.SetActive(true);
        levelSelectText.SetActive(false);
        heartSilhouette.SetActive(false);
        handSilhouette.SetActive(false);
        heartLocked.SetActive(false);
    }
    public void Handlevelbutton()
    {
        SceneManager.LoadScene("Hand_Level");
    }
    public void HeartLevel()
    {
        handintro.SetActive(false);
        heartintro.SetActive(true);
        levelSelectText.SetActive(false);
        heartSilhouette.SetActive(false);
        handSilhouette.SetActive(false);
        heartLocked.SetActive(false);
    }
    public void HeartLevelButton()
    {
        SceneManager.LoadScene("Heart_Level");
    }
    public void BrainLevelButton()
    {
        SceneManager.LoadScene("Brain level");
    }
}
