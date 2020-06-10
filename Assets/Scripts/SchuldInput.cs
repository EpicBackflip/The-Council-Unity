using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class SchuldInput : MonoBehaviour
{
    public int Input;
    public string StringInput;
    public InputField mainInputField;

    public void Awake()
    {
        // this is where the name of the string is set and the stringinput will wait for the input
        StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        mainInputField.text = StringInput;
    }
    public void Savethis()
    {
        // set the stringinput to be the string that is put into the SchuldInput
        StringInput = mainInputField.text;
        PlayerPrefs.SetString("tutorialTextKeyName", StringInput);
    }


}
