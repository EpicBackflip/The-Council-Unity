﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    private static Action OnLoaderCallBack;
    public enum Scenes
    {
        tutorial,
        menu,
        inGame,
        Chapter_1,
        Chapter_2,
    };

    public enum playDirections
    {
        Next, 
        Previous, 
    }

    public static void Load(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

    public static void sceneController(Scene scene, playDirections dir)
    {
        int sceneToLoad = 0; 

        if (dir == playDirections.Next)
        {
            sceneToLoad = scene.buildIndex + 1;
        }

        if (dir == playDirections.Previous)
        {
            sceneToLoad = scene.buildIndex - 1; 
        }

        if (sceneToLoad >= SceneManager.sceneCountInBuildSettings || sceneToLoad <= 0)
        {
            Debug.Log("Scene at buildIndex: " + sceneToLoad + " does not exist.");
            return; 
        }

        SceneManager.LoadScene(sceneToLoad);
    }
}