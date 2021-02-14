using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class session : MonoBehaviour
{
    public int pointPerEnemy;
    public Text score;
    public int currentScore = 0;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<session>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {
        score.text = currentScore.ToString();
    }

    public void AddtoScore()
    {
        currentScore = currentScore += pointPerEnemy;
        score.text = currentScore.ToString();

    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}

