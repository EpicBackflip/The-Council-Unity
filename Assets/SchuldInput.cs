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
        //Adds a listener to the main input field and invokes a method when the value changes.
        //StringInput = mainInputField.text;
        //mainInputField.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
        StringInput = PlayerPrefs.GetString("tutorialTextKeyName");
        mainInputField.text = StringInput;
        Debug.Log(mainInputField.text);


    }



    public void Savethis()
    {
       
        StringInput = mainInputField.text;
        PlayerPrefs.SetString("tutorialTextKeyName", StringInput);
    }


}
