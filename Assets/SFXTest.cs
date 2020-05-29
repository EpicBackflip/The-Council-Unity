using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXTest : MonoBehaviour
{
    public AudioSource Test;
    public CameraZoomComponent cam2;
    public float timer = 0;

    public void Update()
    {
       Console.WriteLine(timer);
        timer++;
        if (cam2.Paused)
        {
            PauseTest();
        }

        if (!cam2.Paused)
        {
            PlayTest();
        }
    }
    public void PlayTest()
    {
        Test.Play();
    }

    public void PauseTest()
    {
        Test.Pause();
    }
}
