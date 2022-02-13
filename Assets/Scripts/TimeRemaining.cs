using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeRemaining : MonoBehaviour
{
    public float gameTime;
    public float timeToSeconds;
    public float timeToMinutes;
    public bool alarm = false;

    // Update is called once per frame
    void Update()
    {
        if(gameTime > 0.01f)
        {
            gameTime -= Time.deltaTime;
            timeToMinutes = (gameTime / 60);
            timeToSeconds = gameTime % 60;
        }
        else
        {
            alarm = true;
        }
    }
}
