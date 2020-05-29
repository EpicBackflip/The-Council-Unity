using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KredietScore : MonoBehaviour
{
    public AudioSource KredietAudio;
    public CameraZoomComponent cam;
    void Start()
    {
        //KredietAudio.PlayDelayed(39.0f);
    }


    void Update()
    {

        if (cam.paused)
        {

            KredietAudio.Pause();

        }
        else
        {
            KredietAudio.UnPause();
        }

    }
}
