using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HighScore : MonoBehaviour
{
    string highScoreKey = "HighScore";
    public static int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = highScore.ToString();
        if (ScoreCount.score > highScore)
        {
            highScore = ScoreCount.score;
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();
        }
    }
}
