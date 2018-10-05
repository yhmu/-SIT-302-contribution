using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI_UI_Button : MonoBehaviour
{

    public void BackMenu()
    {
        SceneManager.LoadScene("UIDesgin");
    }

    public void QuitAll()
    {
        Debug.Log("Quit!!!!!");
        Application.Quit();
    }
}

