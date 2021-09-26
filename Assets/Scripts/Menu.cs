using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}