using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_script : MonoBehaviour
{
    public GameObject page1;
    public GameObject page2;

    public void Xbutton()
    {
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
