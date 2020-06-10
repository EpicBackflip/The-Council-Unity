using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Score : MonoBehaviour
{

    public Text scoreText;
    public int CoinScore;
    public string StringInput;
    public void Awake()
    {
        // this is where the name of the string is set and the stringinput will wait for the input
        StringInput = PlayerPrefs.GetString("Score");
    }

public void Update()
    {
        // this turns the coinscore into a string to be displayed
        scoreText.text = CoinScore.ToString();
        // this saves the string
        PlayerPrefs.SetString("Score", CoinScore.ToString());
    }
}
