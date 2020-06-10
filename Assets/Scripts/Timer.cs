using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Text timerText;
    public float timer = 30f;

    public void Update()
    {
        // this is a timer that counts down based on the time in seconds
        timer -= Time.deltaTime;
        // this turns the timer into an int which looks better when displayed
        int seconds =(int)(timer);
        // this turns the int into a string to be displayed
        timerText.text = seconds.ToString();
        // when the timer reaches 0 switch to the MiniGameOver scene
        if(timer < 0)
        {
            Loader.Load(Loader.Scenes.MiniGameOver);
        }
    }
}
