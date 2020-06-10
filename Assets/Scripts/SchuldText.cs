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
        //get the string from the SchuldInput scene
        schuldinput.StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        schuldinput.mainInputField.text = schuldinput.StringInput;
        schuldText.text = schuldinput.mainInputField.text;
        // this turns the string into an int
        displaySchuld = int.Parse(schuldText.text);
    }
    void Update()
    {
        // this turns the int back into a string to be displayed
        schuldText.text = displaySchuld.ToString();
    }
}
