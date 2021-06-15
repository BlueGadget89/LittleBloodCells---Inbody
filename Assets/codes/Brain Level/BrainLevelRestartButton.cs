using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrainLevelRestartButton : MonoBehaviour
{
    public void restartButton()
    {
        SceneManager.LoadScene("Brain level");
    }
}
