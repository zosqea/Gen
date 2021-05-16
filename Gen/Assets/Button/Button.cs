using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void ClickStart()
    {
        SceneManager.LoadScene(1);
    }
    public void ClickSettings()
    {
        SceneManager.LoadScene(2);
    }
    public void ClickExit()
    {
        Application.Quit();
    }
    public void ClickMenu()
    {
        SceneManager.LoadScene(0);
    }
}
