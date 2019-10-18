using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour
{

    public Text timerText;
    public float totalTime;
    int seconds;
    public bool ScreenCtrl = false;

    void Update()
    {
        totalTime -= Time.deltaTime;
        seconds = (int)totalTime;
        timerText.text = seconds.ToString();

        if (timerText.text == "0")
        {
            ScreenCtrl = true;
        }
    }
}