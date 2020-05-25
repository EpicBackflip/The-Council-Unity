using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Score : MonoBehaviour
{
   //public SchuldInput schuldinput;
    public Text scoreText;
    public int CoinScore;
    public string StringInput;

    // Update is called once per frame

    public void Awake()
    {

        StringInput = PlayerPrefs.GetString("Score");


    }

public void Update()
    {
        //schuldinput.Input = int.Parse(schuldinput.mainInputField.text);
        //scoreText.text = schuldinput.Input.ToString();
        //scoreText.text = schuldinput.StringInput;
        //schuldinput.StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        //schuldinput.mainInputField.text = schuldinput.StringInput;

        //scoreText.text = schuldinput.mainInputField.text;
        /*
        if (CoinScore == int.Parse(schuldinput.mainInputField.text))
        {
            Loader.Load(Loader.Scenes.Win);
            Debug.Log("Win");
        }
        */
        
        //CoinScore = int.Parse(schuldinput.mainInputField.text);
        scoreText.text = CoinScore.ToString();
        PlayerPrefs.SetString("Score", CoinScore.ToString());
        //Debug.Log(CoinScore);
    }
}
