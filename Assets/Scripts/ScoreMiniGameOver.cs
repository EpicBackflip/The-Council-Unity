using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMiniGameOver : MonoBehaviour
{
    public Text scoreTextMiniGameOVer;
    private string ScoreInput;

    private void Awake()
    {
        // this is where the name of the string is set and the stringinput will wait for the input
        ScoreInput = PlayerPrefs.GetString("Score");
    }

    private void Update()
    {
        // this displays the string
        scoreTextMiniGameOVer.text = ScoreInput;
    }
}
