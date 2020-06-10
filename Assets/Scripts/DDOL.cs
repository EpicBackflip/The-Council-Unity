using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{ 
   public DDOL ddol;
   public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("DDOL"+gameObject.name);
    }
}
