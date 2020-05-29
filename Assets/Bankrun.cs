using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bankrun : MonoBehaviour
{
    
    public AudioSource BankAudio;
    public CameraZoomComponent cam;
    void Start()
    {


        BankAudio.PlayDelayed(72.0f);


    }


    void Update()
    {

        if (cam.paused)
        {

            BankAudio.Pause();

        }
        else
        {
            BankAudio.UnPause();
        }

    }
}
