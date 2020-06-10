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
        // this is where the name of the string is set and the stringinput will wait for the input
        ScoreInput = PlayerPrefs.GetString("Score");
    }

    void Update()
    {
        // this displays the string
        scoreText.text = ScoreInput;
    }
}
