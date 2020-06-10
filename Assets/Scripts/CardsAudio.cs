using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class CardsAudio : BaseExplanationAudio
{
    //public AudioClip clip;
    //public Camera cam;
    // private Vector3 position = new Vector3(427, -5, -1);


    public void Play()
    {
        Audio.Play();
        //AudioSource.PlayClipAtPoint(clip, position);
    }
    public void Pause()
    {

        Audio.Stop();
        Zoom.cards.IsPlaying = false;
    }
    void Update()
    {


        if (Zoom.Paused)
        {

            Audio.Pause();

        }
        else
        {
            Audio.UnPause();
        }

    }
}
