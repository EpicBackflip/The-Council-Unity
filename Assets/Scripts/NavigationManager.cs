using UnityEngine;

public class NavigationManager : MonoBehaviour
{
    // Used to switch the current target
    public CameraZoomComponent zoom;
    // Check if the tutorial is currently running 
    public ControlsTutorial controls;

    // If the left side of the screen is pressed, go to the previous target
    public void Back()
    {
        if (!CheckIfCanProceed())
        {
            return;
        }

        zoom.PreviousTarget();
    }

    // If the center of the screen is pressed, the game will be paused or un-paused 
    public void Pause()
    {
        if (!CheckIfCanProceed())
        {
            return;
        }

        zoom.Paused = !zoom.Paused;
    }

    // If the right side of the screen is pressed, go to next target
    public void Next()
    {
        if (!CheckIfCanProceed())
        {
            return;
        }

        zoom.NextTarget();
    }

    // If the tutorial for the controls is still playing, we don't want the player to skip, pause or return 
    private bool CheckIfCanProceed()
    {
        return controls.IsFinished;
    }
}

// Rinske's code
