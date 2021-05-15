using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PressSpaceToAdvance : MonoBehaviour
{
    public bool spacePressed;
    public float destroyTimer;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().color = new Color(255, 255, 255, 0);
        StartCoroutine(FadeTextToFullAlpha(1f, GetComponent<TextMeshProUGUI>()));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(FadeTextToZeroAlpha(1f, GetComponent<TextMeshProUGUI>()));
            spacePressed = true;
        }
        if (spacePressed == true)
        {
            destroyTimer += Time.deltaTime;
        }
        if (destroyTimer >= 1)
        {
            Destroy(gameObject);
        }
    }

    public IEnumerator FadeTextToZeroAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 1);
        while (i.color.a > 0.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a - (Time.deltaTime / t));
            yield return null;
        }
    }
    public IEnumerator FadeTextToFullAlpha(float t, TextMeshProUGUI i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);
        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }
}
