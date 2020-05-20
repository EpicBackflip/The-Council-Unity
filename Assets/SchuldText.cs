using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchuldText : MonoBehaviour
{
    public SchuldInput schuldinput;
    public Text schuldText;
    public Score score;

    private int displaySchuld;

    void Awake()
    {
        schuldinput.StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        schuldinput.mainInputField.text = schuldinput.StringInput;
        schuldText.text = schuldinput.mainInputField.text;

        displaySchuld = int.Parse(schuldText.text);

        //totalScore = score.CoinScore;
    }
    void Update()
    {
            //displaySchuld--;
            schuldText.text = displaySchuld.ToString();
    }
}
