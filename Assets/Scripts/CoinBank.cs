using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBank : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, screenPoint.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint);
        transform.position = curPosition;

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



