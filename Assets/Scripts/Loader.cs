using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{
    //Add all scenes to an enum, for ease of use. 
    public enum Scenes
    {
        menu,
        Chapter_1,
        MiniGame,
        MiniGameOver,
        MiniGameUitleg,
    };

    //We can now call Load('scene') instead of having to write the whole SceneManagement code. 
    public static void Load(Scenes scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }
}
