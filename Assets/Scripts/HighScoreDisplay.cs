using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

public class HighScoreDisplay : MonoBehaviour {

    int score;
    int highscore = 0;
    Text highScoreText;

	// Use this for initialization
	void Start ()
    {
        SetHighScore();
        DisplayHighScore();
    }  

    private void SetHighScore()
    {
        score = FindObjectOfType<GameSession>().GetScore();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
        }
    }

    private void DisplayHighScore()
    {
        highScoreText = GetComponent<Text>();
        highScoreText.text = highscore.ToString();
    }

    // Update is called once per frame
    void Update () {
        
	}

    
}
