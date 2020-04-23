using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventCard : MonoBehaviour
{
    public float sec = 1000f;

   
    void Start()
    {

        

    }

    void Update()
    {
        Debug.Log(sec);
        sec--;
        if(sec <= 0)
        {
            this.GetComponent<Renderer>().material.color = new Color(255.0f, 255.0f, 255.0f, 1.0f);


        }

    }
/*
    IEnumerator LateCall()
    {

       

        
        //Do Function here...
    }

    */
}
