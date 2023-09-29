using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
 public void Level1()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1.0f;
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
