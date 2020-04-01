using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class square : MonoBehaviour
{
    public Transform Square;
    float x;
    float y;
    bool mouseDown = false;



    void Start()
    {




    }


    void OnGUI()
    {

        if (mouseDown)
        {
            GUI.Label(new Rect(10, 10, 100, 100), "Hier worden alle groene blokjes neergelegd");
        }

    }


    void Update()
    {
        /*
        x = Input.mousePosition.x;
        y = Input.mousePosition.y;
       
        if (x >= Square.position.x &&
            x <= Square.position.x
            && y >= Square.position.y &&
            y <= Square.position.y)
        {
            Debug.Log(Square.position.x);
        }

       */
    }

    void OnMouseOver()
    {
        mouseDown = true;

    }

    void OnMouseExit()
    {
        mouseDown = false;

    }




}