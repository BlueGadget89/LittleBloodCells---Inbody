using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class IntroTextOpacityScript : MonoBehaviour
{
    public bool running1;
    public bool running2;
    public bool fading;
    public bool textIsStopped;

    public List<string> sceneTextString = new List<string>();
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        sceneTextString.Add("Welcome, young one.");
        sceneTextString.Add("A dark fate has befallen the kingdom which I rule.");
        sceneTextString.Add("The sickness haunts my kingdom.");
        sceneTextString.Add("The sickness haunts my body.");
        sceneTextString.Add("Your mission is to cure me of my sickness.");
        sceneTextString.Add("Your journey begins now...");
        textIsStopped = false;
        GetComponent<TextMeshProUGUI>().color = new Color(97, 65, 59, 0);
        StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TextMeshProUGUI>()));
    }

    // Update is called once per frame
    void Update()
    {
        if (x > 5)
        {
            SceneManager.LoadScene("LevelSelection");
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
    }

    void textchanger()
    {
        GetComponent<TextMeshProUGUI>().text = sceneTextString[x];
    }

    //Most of this stuff is from here: forum.unity.com/threads/fading-in-out-gui-text-with-c-solved.380822/
    //The rest is improvised

    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(97, 65, 59, 0);
        while (i.color.a < 1.0f)
        {
            running1 = true;
            i.color = new Color(97, 65, 59, i.color.a + (Time.deltaTime / t));
            yield return null;
            running1 = false;
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(97, 65, 59, 1);
        while (i.color.a > 0.0f)
        {
            running2 = true;
            i.color = new Color(97, 65, 59, i.color.a - (Time.deltaTime / t));
            yield return null;
            running2 = false;
        }
    }
}
