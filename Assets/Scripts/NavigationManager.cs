using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    public CameraZoomComponent zoom;
    public ControlsTutorial controls;
    public void Back()
    {
        if(!checkIfCanProceed())
            return;

       zoom.PreviousTarget();
    }

    public void Pause()
    {
        if (!checkIfCanProceed())
            return;

        zoom.Paused = !zoom.Paused;
    }

    public void Next()
    {
        if (!checkIfCanProceed())
            return;

        zoom.NextTarget();
    }

    // If the tutorial for the controls is still playing, we dont want the player to skip, pause or return. 
    private bool checkIfCanProceed()
    {
        if (!controls.IsFinished)
            return false;

        return true; 
    }
}
