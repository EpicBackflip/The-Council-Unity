using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventCard : MonoBehaviour
{
    public float sec = 14f;
 
    void Start()
    {
        if (gameObject.activeInHierarchy) {
            gameObject.SetActive(false);
        }


        CancelInvoke();


    }

    void Update()
    {
        sec--;
        if(sec <= 0)
        {
           // StartCoroutine(LateCall());
            gameObject.SetActive(true);
        }

    }
/*
    IEnumerator LateCall()
    {

       

        
        //Do Function here...
    }

    */
}
