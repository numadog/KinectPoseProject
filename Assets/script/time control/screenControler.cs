using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class screenControler : MonoBehaviour
{
    public TimerController TimerController;
    [SerializeField] GameObject TimePanel;
    [SerializeField] GameObject TextPanel;

    // Update is called once per frame
    void Update()
    {
        if (TimerController.ScreenCtrl == false)
        {
            TextPanel.SetActive(false);
            TimePanel.SetActive(true);
        }

        else if (TimerController.ScreenCtrl == true)
        {
            TextPanel.SetActive(true);
            TimePanel.SetActive(false);
        }
    }
}
