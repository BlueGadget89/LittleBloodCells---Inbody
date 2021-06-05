using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart_Button_Script : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject playerObject;
    public GameObject playerWeapon;
    public int pageNumber;

    private void Start()
    {
        playerWeapon = GameObject.Find("weapon");
        playerObject.GetComponent<PlayerMovementScript>().moveSpeed = 0;
        playerObject.GetComponent<PlayerMovementScript>().JumpForce = 0;
    }

    public void Xbutton()
    {
        playerObject.GetComponent<PlayerMovementScript>().enabled = true;
        playerWeapon.GetComponent<aiming>().enabled = true;
        playerObject.GetComponent<PlayerMovementScript>().moveSpeed = 5;
        playerObject.GetComponent<PlayerMovementScript>().JumpForce = 9;
        Destroy(gameObject);
    }

    public void Update()
    {
        if (pageNumber == 1)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
        }
        if (pageNumber == 2)
        {
            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
        }
    }

    public void NextButton()
    {
        pageNumber += 1;
    }

    /*
    public void Nextbutton()
    {
        if (pageNumber == 1)
        {
            page1.SetActive(false);
            page2.SetActive(true);
            page3.SetActive(false);
            pageNumber += 1;
        }
        if (pageNumber == 2)
        {
            page1.SetActive(false);
            page2.SetActive(false);
            page3.SetActive(true);
        }
    }
    */
    public void Backbutton()
    {
        page1.SetActive(true);
        page2.SetActive(false);
        page3.SetActive(false);
        pageNumber = 0;
    }

}
