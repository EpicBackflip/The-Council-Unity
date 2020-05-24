using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FichesScript : MonoBehaviour
{
    public Transform Square;
    float x;
    float y;
    bool mouseDown = false;
    public Color basicColor = Color.white;
    public Color hoverColor = Color.cyan;
    public Renderer renderer;


    void Start()
    {


        renderer = GetComponent<Renderer>();
        renderer.material.color = basicColor;

    }


    void OnGUI()
    {

        if (mouseDown)
        {
            GUI.Label(new Rect(10, 10, 100, 100), "Hier worden de bankrun fiches neergelegd");
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
        renderer.material.color = hoverColor;
        mouseDown = true;

    }

    void OnMouseExit()
    {
        renderer.material.color = basicColor;
        mouseDown = false;

    }
}
