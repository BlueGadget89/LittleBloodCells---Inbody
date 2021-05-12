using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class cutsceaneScript : MonoBehaviour
{
    public TextMeshProUGUI scenetext;
    public List<string> sceneTextString = new List<string>();
    public int x = 0;

    public AnimationClip fadein;

    public bool textIsStopped;

    // Start is called before the first frame update
    void Start()
    {
        
        sceneTextString.Add("Welcome, young one.");
        sceneTextString.Add("A dark fate has befallen the kingdom which I rule.");
        sceneTextString.Add("The sickness haunts my kingdom.");
        sceneTextString.Add("The sickness haunts my body.");
        sceneTextString.Add("Your mission is to cure me of my sickness.");
        sceneTextString.Add("Your journey begins now.");
        sceneTextString.Add("Your journey begins now.");
        textIsStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (x > 6)
        {
            SceneManager.LoadScene("LevelSelection");
        }
       textchanger();
    }
    void textchanger()
    {
        
        scenetext.text = sceneTextString[x];
        /*
        if (scenetext.GetComponent<Animator>().playbackTime == 1.5)
        {
            scenetext.GetComponent<Animator>().StopPlayback();
            textIsStopped = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textIsStopped == true)
            {
                scenetext.GetComponent<Animator>().StartPlayback();
                textIsStopped = false;
            }
            //x++;
        }
        if (scenetext.GetComponent<Animator>().playbackTime == 3)
        {
            x++;
            scenetext.GetComponent<Animator>().playbackTime = 0;
        }
        
        if (scenetext.GetComponent<TextMeshProUGUI>().color.a == 255)
        {
            //scenetext.GetComponent<Animator>().StopPlayback();
            
            textIsStopped = true;
            Debug.Log("Text is stopped");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textIsStopped == true)
            {
                scenetext.GetComponent<Animator>().StartPlayback();
                textIsStopped = false;
                Debug.Log("Text is resumed");
            }
        }
        if (scenetext.GetComponent<TextMeshProUGUI>().color.a == 0)
        {
            //x++;
            //scenetext.GetComponent<Animation>().Rewind();
            Debug.Log("Text is reset");
        }
        */
    }
}
