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
    public GameObject heartSilhouette, handSilhouette,brainSilhouette, heartLocked,brainLocked;
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
        brainLocked.SetActive(false);
        heartintro.SetActive(false);
        handintro.SetActive(true);
        brainintro.SetActive(false);
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
        brainLocked.SetActive(false);
        handintro.SetActive(false);
        heartintro.SetActive(true);
        brainintro.SetActive(false);
        levelSelectText.SetActive(false);
        heartSilhouette.SetActive(false);
        handSilhouette.SetActive(false);
        heartLocked.SetActive(false);
    }
    public void HeartLevelButton()
    {
        SceneManager.LoadScene("Heart_Level");
    }
    public void BrainLevel()
    {
        brainLocked.SetActive(false);
        handintro.SetActive(false);
        brainintro.SetActive(true);
        heartintro.SetActive(false);
        levelSelectText.SetActive(false);
        heartSilhouette.SetActive(false);
        brainSilhouette.SetActive(false);
        handSilhouette.SetActive(false);
        heartLocked.SetActive(false);
    }
    public void BrainLevelButton()
    {
        
        SceneManager.LoadScene("Brain level");
    }
}
