using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaartenAudio : MonoBehaviour
{
    public AudioSource kaartenAudio;
    public CameraZoomComponent cam;
    void Start()
    {


        kaartenAudio.PlayDelayed(110.0f);


    }


    void Update()
    {

        if (cam.paused)
        {

            kaartenAudio.Pause();

        }
        else
        {
            kaartenAudio.UnPause();
        }

    }
}
