using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{ 
   public DDOL ddol;

   public  float timer = 0;
   public void Awake()
    {
        timer++;
        DontDestroyOnLoad(gameObject);
        Debug.Log("DDOL"+gameObject.name);
    

    }
}
