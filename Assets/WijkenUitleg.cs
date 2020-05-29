using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WijkenUitleg : MonoBehaviour
{
    public AudioSource WijkenAudio;
    public CameraZoomComponent cam;
    void Start()
    {

 
        WijkenAudio.PlayDelayed(156);


    }


    void Update()
    {
        if (cam.paused)
        {
            WijkenAudio.Pause();

        }
        else
        {
            WijkenAudio.UnPause();
        }

    }
}
