using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraZoomComponent : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer board;
    public float zoomInMargin;
    public float zoomOutMargin;
    
    public GameObject navParent;

    private int targetIndex = -1;
    public bool paused;
    private float WaitTime = 40f;

    public ControlsTutorial controls; 

    private float baseCameraSize;
    private float screenRatio;

    //Defines the target positions and the amount of the zoom (Z)
    public Vector3[] target;
    private bool isZoomActive;

    //The rate of zoom
    public float zoomSpeed;
    public float timer;
    public GroeneBlokjesAudioDelayed groenblokjes;
    public RodeBlokjesAudioDelayed rodeblokjes;
    public Bankrun bankrun;
    public KredietScore krediet;
    public KaartenAudio kaarten;
    public WijkenUitleg wijken;
    private bool gisPlaying;
    private bool risPlaying;
    private bool bisPlaying;
    private bool kisPlaying;
    private bool kaartisPlaying;
    private bool wijkenisPlaying;
    public float timeraudio;
    public bool Paused
    {
        get { return paused;  }
        set { paused = value;  }
    }

    public void Start()
    {
        screenRatio = (float)Screen.width / Screen.height;
        float targetRatio = board.bounds.size.x / board.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            baseCameraSize = board.bounds.size.y / 2;
        }
        else
        {
            float difference = targetRatio / screenRatio;
            baseCameraSize = board.bounds.size.y / 2 * difference; 
        }
    }

    public void Update()
    {
       

        if (!paused)
        {
            timer += Time.deltaTime;
        }
        if (timer > WaitTime)
        {
            isZoomActive = false;
            timer = 0;
        }

        if (paused || !controls.IsFinished)
        {
            return;
        }

        if (targetIndex > target.Length - 1)
            return;

        //if (cam.orthographicSize < target[targetIndex].z + zoomInMargin)
        //{
        //    isZoomActive = false;
        //}

        if (!isZoomActive && cam.orthographicSize > baseCameraSize - zoomOutMargin)
        {
           NextTarget();
        }

        if (isZoomActive && targetIndex == 0 && !gisPlaying)
        {
            Console.WriteLine("hit");
            groenblokjes.Play();
            gisPlaying = true;
        }

        if (isZoomActive && targetIndex == 1 && !risPlaying)
        {
            Console.WriteLine("hit");
            rodeblokjes.Play();
            risPlaying = true;
        }

        if (isZoomActive && targetIndex == 2 && !bisPlaying)
        {
          
            Console.WriteLine("hit");
            bankrun.Play();
            bisPlaying = true;
        }
        /*
        if (isZoomActive && targetIndex == 2 && !kisPlaying )
        {
            Console.WriteLine("hit");
            krediet.Play();
            kisPlaying = true;
        }
        */

        if (isZoomActive && targetIndex == 3 && !kaartisPlaying)
        {
            Console.WriteLine("hit");
            kaarten.Play();
            kaartisPlaying = true;
        }

        if (isZoomActive && targetIndex == 4 && !wijkenisPlaying)
        {
            Console.WriteLine("hit");
            wijken.Play();
            wijkenisPlaying = true;
        }






        if (isZoomActive && targetIndex < target.Length)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, target[targetIndex].z, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(target[targetIndex].x, target[targetIndex].y, -1), zoomSpeed);
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, baseCameraSize, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(0,0,-1), zoomSpeed);
        }

        float height = cam.orthographicSize * 2;
        float width = height * screenRatio; 

        navParent.transform.localScale = Vector3.one * height / 525f;
    }

    public void NextTarget()
    {
        isZoomActive = true;
        targetIndex++;

        if (targetIndex >= target.Length)
        {
            Loader.Load(Loader.Scenes.menu);
        }
    }

    public bool PreviousTarget()
    {
        if (targetIndex == 0)
        {
            return true;
        }

        targetIndex--;
        isZoomActive = true;
        return false;
    }
}
