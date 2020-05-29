using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodeBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource RodeAudio;
    public CameraZoomComponent cam;
    public float delayTimer;
    void Start()
    {
        delayTimer = 37;
        RodeAudio.PlayDelayed(delayTimer);



    }


    void Update()
    {
     
        if (cam.paused)
        {
            delayTimer += Time.deltaTime;
            RodeAudio.Pause();

        }
        else
        {
            RodeAudio.UnPause();
        }

    }
}

