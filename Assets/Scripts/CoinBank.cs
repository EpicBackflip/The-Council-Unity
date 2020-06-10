using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBank : MonoBehaviour
{
    private Vector3 screenPoint;

    void OnMouseDown()
    {
        //hier zorg je ervoor dat wanneer je op de coinbank klikt de position veranderd kan worden.
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    void OnMouseDrag()
    { 
        //wanneer de muis wordt ingehouden wordt de position van coinbank gelijk gezet aan de x positie van de muis.
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

        // hier wordt de positie gesrestrained wanneer de conibank de randen van het scherm raakt.
        if (transform.position.x >= 8)
        {
           transform.position = new Vector3(8, -3.63f, 0);
        }

        if (transform.position.x <= -8)
        {
           transform.position = new Vector3(-8, -3.63f, 0);
        }
    }
}



