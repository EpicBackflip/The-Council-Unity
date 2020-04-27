using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public Text timerText;
    public float timer = 30f;

    // Update is called once per frame
    public void Update()
    {
        timer -= Time.deltaTime;
        int seconds =(int)(timer % 60);

        timerText.text = seconds.ToString();
        if(timer < 0)
        {

            Loader.Load(Loader.Scenes.MiniGameOver);
        }
    }
}
