using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControlsTutorial : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image[] panels;

    Color tempColor = new Color(0,0,0,0);

    public float maxOpacityChange = 0.45f;
    public float changeRate = 0.02f;
    int blinkCount;

    private int index;
    private static bool isFinished;
    private bool hasBlinked; 
    public bool IsFinished
    {
        get { return isFinished;  }
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Entering " + name + " GameObject");
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Cursor Exiting " + name + " GameObject");
    }

    void Start()
    {
        isFinished = false; 
    }

    void Update()
    {
        if (blinkCount == 2)
        {
            index++;
            blinkCount = 0;
        }

        if (tempColor.a <= maxOpacityChange && !hasBlinked)
        {
            tempColor.a += changeRate;

            if (tempColor.a >= maxOpacityChange)
                hasBlinked = true;
        }
        else
        {
            tempColor.a -= changeRate;

            if (tempColor.a <= 0f)
            {
                hasBlinked = false;
                blinkCount++;
            }
        }

        if (index < panels.Length)
        {
            panels[index].color = tempColor;
        }
        else
        {
            isFinished = true;
        }
    }
}
