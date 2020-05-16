using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Previous : MonoBehaviour
{
    private int sceneToLoad; 
    public void previousScene()
    {
        Scene scene = SceneManager.GetActiveScene();

        Loader.sceneController(scene, Loader.playDirections.Previous);
    }
}
