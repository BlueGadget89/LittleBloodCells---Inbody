using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class OutroText : MonoBehaviour
{
    public bool running1;
    public bool running2;
    public bool fading;
    public bool textIsStopped;

    public GameObject fadingObject;
    public float sceneChangeTimer;
    public bool sceneChanging;

    public List<string> sceneTextString = new List<string>();
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        sceneTextString.Add("Well done, young one.");
        sceneTextString.Add("Your courage in the face of malice has saved the kingdom.");
        sceneTextString.Add("My spirit has been reignited.");
        sceneTextString.Add("Myself, along with the kingdom, has been cured from this sickness.");
        sceneTextString.Add("Kingdoms will always be vulnerable.");
        sceneTextString.Add("Walls will crumble and walls will be built");
        sceneTextString.Add("But may your spirit never dwindle.");
        sceneTextString.Add("Keep your hands close to your heart and your mind.");
        sceneTextString.Add("Go on, and live young one.");
        sceneTextString.Add("Go on, and live...");
        textIsStopped = false;
        GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, 0);
        StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TextMeshProUGUI>()));
    }

    // Update is called once per frame
    void Update()
    {
        if (x == 9)
        {
            sceneChanging = true;
        }
        textchanger();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (running1 == false)
            {
                StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<TextMeshProUGUI>()));
                fading = true;
            }
        }
        if (running2 == false)
        {
            if (fading == true)
            {
                x++;
                StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TextMeshProUGUI>()));
                fading = false;
            }
        }
        if (sceneChanging == true)
        {
            sceneChangeTimer += Time.deltaTime;
            fadingObject.GetComponent<SceneFadeScript>().running2 = true;
            fadingObject.SetActive(true);
            fadingObject.GetComponent<SceneFadeScript>().isTransitioning = true;
        }
        if (sceneChangeTimer >= 2)
        {
            SceneManager.LoadScene("OutroCredits");
        }
    }

    void textchanger()
    {
        GetComponent<TextMeshProUGUI>().text = sceneTextString[x];
    }

    //Most of this stuff is from here: forum.unity.com/threads/fading-in-out-gui-text-with-c-solved.380822/
    //The rest is improvised

    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            running1 = true;
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
            running1 = false;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            running2 = true;
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
            running2 = false;
        }
    }
}
