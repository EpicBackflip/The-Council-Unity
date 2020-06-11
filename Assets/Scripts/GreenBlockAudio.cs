using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;

public class GreenBlockAudio : BaseExplanationAudio
{

    public void Play()
    {
        //this is where the audio gets played
        Audio.Play();
    }

    public void Pause()
    {
        //this is where the audio get's stopped
        Audio.Stop();
        Zoom.greenBlocks.IsPlaying = false;
    }

    private void Update()
    {
        //when the camera zoom is paused the audio will be paused aswell
        if (Zoom.Paused)
        { 
            Audio.Pause();
        }
        //when the camera zoom is unpaused the audio will be unpaused aswell

        else
        {
           Audio.UnPause();
        }
        
    }
}
