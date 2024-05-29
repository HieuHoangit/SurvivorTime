using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadMenuScene()
    {
        SceneManager.LoadScene("menu");
    }
    public void LoadPlaytScene()
    {
        SceneManager.LoadScene("manchoi");
    }

    public void LoadInstructScene()
    {
        SceneManager.LoadScene("huongdan");
    }
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("man1");
    }

    public void LoadGameplay2Scene()
    {
        SceneManager.LoadScene("man2");
    }
    public void LoadGameplay3Scene()
    {
        SceneManager.LoadScene("man3");
    }
    public void LoadSettingScene()
    {
        SceneManager.LoadScene("caidat");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

