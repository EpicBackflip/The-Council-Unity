using UnityEngine;

public class CameraZoomComponent : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer board;

    // This is used to change the duration when zoomed-in on a target
    public float zoomOutMargin;

    public GameObject navParent;

    // Indicates the current target 
    private int targetIndex = -1;

    // Indicates if the game is paused or not
    private bool paused;

    // Max time that we are zoomed-in
    private float waitTime = 40f;

    public ControlsTutorial controls;

    private float baseCameraSize;
    private float screenRatio;

    // Defines the target positions and the amount of the zoom (Z)
    public Vector3[] target;
    private bool isZoomActive;

    // The rate of zoom variables
    public float zoomSpeed;
    public float timer;

    // Audio variables 
    public GreenBlockAudio greenBlocks;
    public RedBlockAudio redBlocks;
    public Bankrun bankrun;
    public CreditScore credit;
    public CardsAudio cards;
    public StreetAudio street;

    // Pause the game or check if the game is paused
    public bool Paused
    {
        get { return paused; }
        set { paused = value; }
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
        // If the game is not paused, update the timer
        if (!paused)
        {
            timer += Time.deltaTime;
        }

        // If the timer exceeds the wait time, stop zooming
        if (timer > waitTime)
        {
            isZoomActive = false;
            timer = 0;
        }

        // If the game is paused or the tutorial is playing, don't do anything
        if (paused || !controls.IsFinished)
        {
            return;
        }

        // If the current target is more then the max amount of targets, don't do anything
        if (targetIndex > target.Length - 1)
        {
            return;
        }

        // If we have reached the max zoom of the current target, go to the next target 
        if (!isZoomActive && cam.orthographicSize > baseCameraSize - zoomOutMargin)
        {
           NextTarget();
        }

        // Play the explanation sound for the groene blokjes & pause the other sounds 
        if (isZoomActive && targetIndex == 0 && !greenBlocks.IsPlaying)
        {
            greenBlocks.IsPlaying = true;
            greenBlocks.Play();
            redBlocks.Pause();
            bankrun.Pause();
            cards.Pause();
            street.Pause();
            credit.Pause();
        }

        // Play the explanation sound for the rode blokjes & pause the other sounds 
        if (isZoomActive && targetIndex == 1 && !redBlocks.IsPlaying)
        {
            redBlocks.IsPlaying = true;
            redBlocks.Play();
            greenBlocks.Pause();
            bankrun.Pause();
            cards.Pause();
            street.Pause();
            credit.Pause();
        }

        // Play the explanation sound for the bankrun & pause the other sounds 
        if (isZoomActive && targetIndex == 2 && !bankrun.IsPlaying)
        {
            bankrun.IsPlaying = true;
            bankrun.Play();
            greenBlocks.Pause();
            redBlocks.Pause();
            cards.Pause();
            street.Pause();
            credit.Pause();
        }

        // Play the explanation sound for the cards & pause the other sounds 
        if (isZoomActive && targetIndex == 3 && !cards.IsPlaying)
        {
            cards.IsPlaying = true;
            cards.Play();
            greenBlocks.Pause();
            redBlocks.Pause();
            bankrun.Pause();
            street.Pause();
            credit.Pause();
        }

        // Play the explanation sound for the street & pause the other sounds 
        if (isZoomActive && targetIndex == 4 && !street.IsPlaying)
        {
            street.IsPlaying = true;
            street.Play();
            greenBlocks.Pause();
            redBlocks.Pause();
            bankrun.Pause();
            cards.Pause();
            credit.Pause();
        }

        // Play the explanation sound for the credit & pause the other sounds 
        if (isZoomActive && targetIndex == 5 && !credit.IsPlaying)
        {
            credit.IsPlaying = true;
            credit.Play();
            greenBlocks.Pause();
            redBlocks.Pause();
            cards.Pause();
            street.Pause();
            bankrun.Pause();
        }

        if (isZoomActive && targetIndex < target.Length)
        {
            // We know how far we can zoom-in by using the z-component & we can set the targets x and y positions
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, target[targetIndex].z, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(target[targetIndex].x, target[targetIndex].y, -1), zoomSpeed);
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, baseCameraSize, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(0,0,-1), zoomSpeed);
        }

        float height = cam.orthographicSize * 2;
        
        navParent.transform.localScale = Vector3.one * height / 525f;
    }

    // Go to the next target. If there are no targets left, go to next scene
    public void NextTarget()
    {
        isZoomActive = true;
        targetIndex++;

        if (targetIndex >= target.Length)
        {
            Loader.Load(Loader.Scenes.menu);
        }
    }

    // Go to the previous target. If there are no targets left, go to previous scene
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
