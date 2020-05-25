using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    public CameraZoomComponent zoom;
    public Previous previous;

    public void Back()
    {
        var goToPreviousScene = zoom.PreviousTarget();

        if (goToPreviousScene)
        {
            previous.previousScene();
        }
    }

    public void Pause()
    {
        zoom.paused = !zoom.paused;
    }

    public void Next()
    {
        zoom.NextTarget();
    }
}
