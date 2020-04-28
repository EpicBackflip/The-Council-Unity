using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SchuldText : MonoBehaviour
{
    public SchuldInput schuldinput;
    public Text schuldText;

    void Awake()
    {
        schuldinput.StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        schuldinput.mainInputField.text = schuldinput.StringInput;
    }
    void Update()
    {
        schuldText.text = schuldinput.mainInputField.text;


    }
}
