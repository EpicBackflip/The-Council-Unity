using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodeBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource RodeAudio;
    public CameraZoomComponent zoomm;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        RodeAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }
    public void Pause()
    {
        RodeAudio.Stop();
        zoomm.rodeBlokjesIsPlaying = false;
    }
    void Update()
    {
        if (zoomm.Paused)
        {
            RodeAudio.Pause();
        }
        else
        {
            RodeAudio.UnPause();
        }

    }
}

