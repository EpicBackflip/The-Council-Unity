using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBank : MonoBehaviour
{
    private Vector3 screenPoint;

    private void OnMouseDown()
    {
        //when the coinbank is pressed you enable the position to be changed.
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
    }

    private void OnMouseDrag()
    { 
        //when the mouse is dragged the position will be changed according to the x position of the mouse.
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

        //when the coinbank reaches the end of the screen the position will be restrained.
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



