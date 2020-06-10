using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroeneBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource GroeneAudio;
    public CameraZoomComponent zoom;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        GroeneAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }

    public void Pause()
    {

        GroeneAudio.Stop();
        zoom.groeneBlokjesIsPlaying = false;
    }

    void Update()
    {
        if (zoom.Paused)
        {
            GroeneAudio.Pause();
        }
        else
        {
           GroeneAudio.UnPause();
        }
        
    }
}
