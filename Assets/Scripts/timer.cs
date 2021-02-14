using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timer : MonoBehaviour
{
    public float totalTime;
    public Text text;
    private float seconds;
    private float minutes;
    Level level;

    void Start()
    {
        level = FindObjectOfType<Level>();
    }

    void Update()
    {
        totalTime -= Time.deltaTime;

        seconds = (int)(totalTime % 60);
        minutes = (int)(totalTime / 60);

        ShowText();


        if (minutes <= 0 && seconds <= 0)
        {
            level.LoadTheWin();
        }
    }

    void ShowText()
    {
        if (seconds < 10 && minutes < 10)
        {
            text.text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString();
        }
        else if (minutes < 10 && seconds >= 10)
        {
            text.text = "0" + minutes.ToString() + ":" + seconds.ToString();
        }
        else if (minutes >= 10 && seconds < 10)
        {
            text.text = minutes.ToString() + ":" + "0" + seconds.ToString();
        }
        else
        {
            text.text = minutes.ToString() + ":" + seconds.ToString();
        }

    }
}
