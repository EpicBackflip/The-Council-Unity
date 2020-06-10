using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image panel;

    private float highlightColor = 0.05f; 

    Color tempColor = new Color(0,0,0,0); 
    
    // When the mouse hovers over the panel, highlight it. 
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        tempColor.a = highlightColor;
        panel.color = tempColor;
    }

    // And vice versa. 
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        panel.color = new Color(0,0,0,0);
    }
}
