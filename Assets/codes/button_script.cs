using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_script : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject playerObject;
    public GameObject playerWeapon;
    public string sceneName;
    public GameObject happyFlashObject;

    private void Start()
    {
        playerWeapon = GameObject.Find("weapon");
        playerObject.GetComponent<PlayerMovementScript>().moveSpeed = 0;
        playerObject.GetComponent<PlayerMovementScript>().JumpForce = 0;
        Scene currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        if (sceneName == "Brain level")
        {
            happyFlashObject = GameObject.Find("HappyItemFlashOrder");
        }
    }
    public void Update()
    {

    }

    public void Xbutton()
    {
        if (sceneName == " Brain level")
        {
            happyFlashObject.GetComponent<HappyItemFlashScript>().isFlashing = true;
            Debug.Log("Happy flash started");
        }
        playerObject.GetComponent<PlayerMovementScript>().enabled = true;
        playerWeapon.GetComponent<aiming>().enabled = true;
        playerObject.GetComponent<PlayerMovementScript>().moveSpeed = 5;
        playerObject.GetComponent<PlayerMovementScript>().JumpForce = 9;
        Destroy(gameObject);
    }
    public void Nextbutton()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }
    public void Backbutton()
    {
        page1.SetActive(true);
        page2.SetActive(false);
    }

}
