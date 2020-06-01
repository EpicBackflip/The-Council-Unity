using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WijkenUitleg : MonoBehaviour
{
    public AudioSource WijkenAudio;
    public CameraZoomComponent zoomm;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        WijkenAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }

    public void Pause()
    {

        WijkenAudio.Stop();
        zoomm.wijkenIsPlaying = false;
    }
    void Update()
    {


        if (zoomm.paused)
        {

            WijkenAudio.Pause();

        }
        else
        {
            WijkenAudio.UnPause();
        }

    }
}
