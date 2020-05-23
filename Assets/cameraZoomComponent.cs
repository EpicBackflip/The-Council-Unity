using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class cameraZoomComponent : MonoBehaviour
{
    public Camera cam;
    public SpriteRenderer board;
    public float zoomInMargin;
    public float zoomOutMargin;

    public int targetIndex;

    private float baseCameraSize;

    //Defines the target positions and the amount of the zoom (Z)
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
        if(cam.orthographicSize < target[targetIndex].z + zoomInMargin)
        {
            isZoomActive = false;
        }

        if (!isZoomActive && cam.orthographicSize > baseCameraSize - zoomOutMargin)
        {
            isZoomActive = true;
            targetIndex++;
        }

        if (isZoomActive)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, target[targetIndex].z, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(target[targetIndex].x, target[targetIndex].y, -1), zoomSpeed); 
        }
        else
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, baseCameraSize, zoomSpeed);
            cam.transform.position = Vector3.Lerp(cam.transform.position, new Vector3(0,0,-1), zoomSpeed);
        }
    }
}
