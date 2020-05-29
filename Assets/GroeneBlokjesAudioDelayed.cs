using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroeneBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource GroeneAudio;
    public CameraZoomComponent zoomm;
    public AudioClip clip;
    public Camera cam;


    public void Play()
    {
        AudioSource.PlayClipAtPoint(clip, cam.transform.position);
    }

    void Update()
    {

        if (zoomm.paused)
        {
            //
           // GroeneAudio.Pause();

        }
        else
        {
           // GroeneAudio.UnPause();
        }
        
    }
}
