using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    private int sceneToLoad; 
    public void nextScene()
    {
        Scene scene = SceneManager.GetActiveScene();

        Loader.sceneController(scene, Loader.playDirections.Next);
    }
}
