using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Hover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // The color of this panel will be used as a highlight
    public Image panel;

    // The amount to highlight the panel
    private float highlightColor = 0.05f;

    // When the mouse hovers over the panel, highlight it 
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        panel.color = new Color(0, 0, 0, highlightColor);
    }

    // When the mouse hovers over the panel, don't highlight it 
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        panel.color = new Color(0,0,0,0);
    }
}

//Rinske's code
