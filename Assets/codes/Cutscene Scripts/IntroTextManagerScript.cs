using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IntroTextManagerScript : MonoBehaviour
{
    public TextMeshProUGUI introText;
    public float cutsceneTimer;

    // Start is called before the first frame update
    void Start()
    {
        //introText.text = "Welcome, young one";
    }

    // Update is called once per frame
    void Update()
    {
        cutsceneTimer += Time.deltaTime;
    }
}
