using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplayer : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        GameObject car = GameObject.Find("Car");
        int score = car.GetComponent<CollectScore>().playerScore;
        scoreText.text = score.ToString();
        
    }
}
