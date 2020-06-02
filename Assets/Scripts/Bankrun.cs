using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bankrun : MonoBehaviour
{
    public AudioSource BankrunAudio;
    public CameraZoomComponent zoomm;
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        BankrunAudio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }
    public void Pause()
    {

        BankrunAudio.Stop();
        zoomm.bankrunIsPlaying = false;
    }

    void Update()
    {


        if (zoomm.Paused)
        {

            BankrunAudio.Pause();

        }
        else
        {
            BankrunAudio.UnPause();
        }

    }
}
