using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodeBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource RodeAudio;
    public CameraZoomComponent cam;
    //public float delayTimer;
    public AudioClip clip;
    private Vector3 position = new Vector3(-427, -10, -1);
    void Start()
    {
        //delayTimer = 37;
        //RodeAudio.PlayDelayed(delayTimer);



    }
    public void Play()
    {
        AudioSource.PlayClipAtPoint(clip, position);
    }

    void Update()
    {
     
        if (cam.paused)
        {
            //delayTimer += Time.deltaTime;
           // RodeAudio.Pause();

        }
        else
        {
            //RodeAudio.UnPause();
        }

    }
}

