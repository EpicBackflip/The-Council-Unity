using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroeneBlokjesAudioDelayed : MonoBehaviour
{
    public  AudioSource GroeneAudio; 
    void Start()
    {

       
        GroeneAudio.PlayDelayed(2.0f);


    }

  
    void Update()
    {
        
    }
}
