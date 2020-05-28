using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image panel;
    Color tempColor = new Color(0,0,0,0); 
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        tempColor.a = 0.05f;
        panel.color = tempColor;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        panel.color = new Color(0,0,0,0);
    }
}
