﻿using System;
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

    private int targetIndex = 0;
    private bool paused;
    private float WaitTime = 34f;

    public ControlsTutorial controls; 

    private float baseCameraSize;
    private float screenRatio;

    //Defines the target positions and the amount of the zoom (Z)
    public Vector3[] target;
    private bool isZoomActive;

    //The rate of zoom
    public float zoomSpeed;
    private float timer;

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
        timer += Time.deltaTime;

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