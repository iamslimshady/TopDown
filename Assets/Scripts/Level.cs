using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level : MonoBehaviour
{
    int CurrentScene;
    void Start()
    {
        CurrentScene = SceneManager.GetActiveScene().buildIndex;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(CurrentScene + 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<session>().ResetGame();
    }

    public void LoadTheEnd()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void LoadTheWin()
    {
        SceneManager.LoadScene("Win");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
