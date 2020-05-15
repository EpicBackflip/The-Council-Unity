using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomComponent : MonoBehaviour
{
    public Camera cam;

    //The default size of the camera
    private float baseCameraSize = 257.8812f; 

    //The amount we zoom
    public float zoomFactor;

    //Defines the idle position and the position of the zoom
    public Vector3[] target;
    public bool isZoomActive;

    //The rate of zoom
    public float zoomSpeed;

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
