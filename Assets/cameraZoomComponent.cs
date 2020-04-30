using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraZoomComponent : MonoBehaviour
{
    public Camera cam;
    private float targetZoom;
    private float zoomFactor = 80f;
    [SerializeField] private float zoomLerpSpeed = 10f;

    void Start()
    {
        targetZoom = cam.orthographicSize; 
    }
    void Update()
    {
        float scrollData = Input.GetAxis("Mouse ScrollWheel");    
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom, 40f, 263f); 
        cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, targetZoom, Time.deltaTime * zoomLerpSpeed);
    }
}
