using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroeneBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource GroeneAudio;
    public CameraZoomComponent cam;
    void Start()
    {

       
        GroeneAudio.PlayDelayed(2.0f);
      

    }


    void Update()
    {

        if (cam.paused)
        {
            
            GroeneAudio.Pause();

        }
        else
        {
            GroeneAudio.UnPause();
        }
        
    }
}
