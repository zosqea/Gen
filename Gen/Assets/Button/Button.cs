using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject settings;
    public GameObject menu;
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
    public void SttingsG()
    {
        settings.SetActive(true);
        menu.SetActive(false);
    }
    public void SettingsOut()
    {
        settings.SetActive(false);
        menu.SetActive(true);
    }
}
