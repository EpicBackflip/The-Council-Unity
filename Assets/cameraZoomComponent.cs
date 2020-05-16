using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomComponent : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer board; 

    private float baseCameraSize;

    //The amount we zoom
    public float zoomFactor;

    //Defines the idle position and the position of the zoom
    public Vector3[] target;
    public bool isZoomActive;

    //The rate of zoom
    public float zoomSpeed;

    public void Start()
    {
        float screenRatio = (float)Screen.width / Screen.height;
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
    public void LateUpdate()
    {
        if (isZoomActive)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, zoomFactor, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, target[0], zoomSpeed); 
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, baseCameraSize, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, target[1], zoomSpeed);
        }
    }
}
