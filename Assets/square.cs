using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class square : MonoBehaviour
{
    public Transform Square;
    
    float x; 
    float y;

    void Start()
    {

        


    }





    void Update()
    {
       
         x = Input.mousePosition.x;
        y = Input.mousePosition.y;
        if (x >= Square.position.x &&
            x <= Square.position.x
            && y >= Square.position.y &&
            y <= Square.position.y)
        {
            print("yes");
        }

    }

}