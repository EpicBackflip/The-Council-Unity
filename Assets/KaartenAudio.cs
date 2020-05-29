using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KaartenAudio : MonoBehaviour
{
    public AudioSource kaartenAudio;
    public CameraZoomComponent zoomm;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        kaartenAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }
    public void Pause()
    {

        kaartenAudio.Stop();
        zoomm.kaartisPlaying = false;
    }
    void Update()
    {


        if (zoomm.paused)
        {

            kaartenAudio.Pause();

        }
        else
        {
            kaartenAudio.UnPause();
        }

    }
}
