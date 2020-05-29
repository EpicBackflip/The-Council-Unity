using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KredietScore : MonoBehaviour
{
    public AudioSource KredietAudio;
    public CameraZoomComponent zoomm;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        KredietAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }

    void Update()
    {


        if (zoomm.paused)
        {

            KredietAudio.Pause();

        }
        else
        {
            KredietAudio.UnPause();
        }

    }
}
