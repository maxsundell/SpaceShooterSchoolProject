﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour 
{
	
	public int score = 0;
    Text scoreText;

    void Start()
    {

        scoreText = gameObject.GetComponent<Text>();

    }

    void Update()
    {

        string text = "SCORE\\n<b><size=250>" + score.ToString() + "</size></b>";
        scoreText.text = text.Replace("\\n", "\n");

    }

}
