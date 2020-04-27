using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Score : MonoBehaviour
{
    public SchuldInput schuldinput;
    public Text scoreText;
    public int CoinScore;
    

    // Update is called once per frame
    public void Update()
    {
        //schuldinput.Input = int.Parse(schuldinput.mainInputField.text);
        //scoreText.text = schuldinput.Input.ToString();
        //scoreText.text = schuldinput.StringInput;
        schuldinput.StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        schuldinput.mainInputField.text = schuldinput.StringInput;
        schuldinput.Input = int.Parse(schuldinput.StringInput);
        //scoreText.text = schuldinput.mainInputField.text;
        CoinScore = schuldinput.Input;
        //CoinScore = int.Parse(schuldinput.mainInputField.text);
        scoreText.text = CoinScore.ToString();
        Debug.Log(CoinScore);




    }
}
