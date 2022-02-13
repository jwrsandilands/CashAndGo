using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplayer : MonoBehaviour
{
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        GameObject car = GameObject.Find("Car");
        float seconds = car.GetComponent<TimeRemaining>().timeToSeconds;
        string sec = seconds.ToString();
        float minutes = car.GetComponent<TimeRemaining>().timeToMinutes;
        string min = minutes.ToString();

        string[] secondsArray = new string[1];
        secondsArray = sec.Split('.');
        string[] minutesArray = new string[1];
        minutesArray = min.Split('.');

        if(int.Parse(secondsArray[0]) < 10)
        {
            timeText.text = minutesArray[0] + ":0" + secondsArray[0];
        }
        else
        {
            timeText.text = minutesArray[0] + ":" + secondsArray[0];
        }
    }
}
