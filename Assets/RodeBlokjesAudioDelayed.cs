using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodeBlokjesAudioDelayed : MonoBehaviour
{
    public AudioSource RodeAudio;
    void Start()
    {
        RodeAudio.PlayDelayed(35f);
    }


    void Update()
    {

    }
}
