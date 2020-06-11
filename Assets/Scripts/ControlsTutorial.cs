using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControlsTutorial : MonoBehaviour
{
    //Array to hold the control panels
    public Image[] panels;

    //An array to hold the descriptions for the panels
    public String[] descriptions;

    //A public container of textObjects which will display the descriptions
    public Text[] textToDisplay;

    private Color tempColor = new Color(0,0,0,0);

    public float maxOpacityChange = 0.45f;
    public float changeRate = 0.02f;

    private int blinkCount;

    //The amount of times the panel flashes or 'blinks'
    private int maxBlinkAmount = 2; 

    private int index;
    private static bool isFinished;
    private bool hasBlinked;

    //To indicate when the tutorial is done, so the player can start skipping etc.  
    public bool IsFinished
    {
        get { return isFinished;  }
    }

    void Start()
    {
        isFinished = false; 
    }

    void Update()
    {
        //If a panel has completed two full blink "cycles"
        if (blinkCount == maxBlinkAmount)
        {
            //Check if were still inside the array. Set the text of the current panel to empty 
            if(index < descriptions.Length)
                textToDisplay[index].text = String.Empty;

            //Move to the next panel
            index++;
            blinkCount = 0;
        }

        //As long as the opacity (a) is less than the max change, we increase it. 
        if (tempColor.a <= maxOpacityChange && !hasBlinked)
        {
            tempColor.a += changeRate;

            //If we reach max opacity, we set hasBlinked to true. So next update we'll decrease opacity. 
            if (tempColor.a >= maxOpacityChange)
                hasBlinked = true;
        }
        else
        {
            tempColor.a -= changeRate;

            //If we hit 0 opacity, we completed one full blink cycle
            if (tempColor.a <= 0f)
            {
                //Increase the opacity next update
                hasBlinked = false;
                blinkCount++;
            }
        }

        if (index < panels.Length)
        {
            //Set the panel 's color to the new tempColor
            panels[index].color = tempColor;
            //Display the right description
            textToDisplay[index].text = descriptions[index]; 
        }
        else
        {
            //If all panels are done, we're finished
            isFinished = true;
        }
    }
}
