using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class cutsceaneScript : MonoBehaviour
{
    public TextMeshProUGUI scenetext;
    public List<string> sencetext = new List<string>();
    public int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
        sencetext.Add("Welcome, young one.");
        sencetext.Add("A dark fate has befallen the kingdom which I rule.");
        sencetext.Add("The sickness haunts my kingdom.");
        sencetext.Add("The sickness haunts my body.");
        sencetext.Add("Your mission is to cure me of my sickness.");
        sencetext.Add("Your journey begins now.");
        sencetext.Add("Your journey begins now.");

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
        
        scenetext.text = sencetext[x];
        if (Input.GetKeyDown(KeyCode.Space))
        {
            x++;
        }
    }
}
