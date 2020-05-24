using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMiniGameOver : MonoBehaviour
{
    public Text scoreText;
    public string ScoreInput;
    public int CoinScore;

    public void Awake()
    {
        ScoreInput = PlayerPrefs.GetString("Score");

    }

    void Update()
    {
        scoreText.text = ScoreInput;

    }
}
