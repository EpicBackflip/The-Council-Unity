using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Playgame()
    {
        // when the Play button is pressed the game will take you to the minigame explenation scene
        Loader.Load(Loader.Scenes.MiniGameUitleg);
    }

public void StartKnop()
    {
        // when the Start button is pressed the game will take you to the minigame scene
        Loader.Load(Loader.Scenes.MiniGame);
    }
public void Tutorial()
    {
        // when the Tutorial button is pressed the game will take you the tutorial scene
        Loader.Load(Loader.Scenes.Chapter_1);
    }

public void Return()
    {
        // when the Return button is pressed the game will take you to the main menu scene
        Loader.Load(Loader.Scenes.menu);
    }

public void Quit()
    {
        // when the Quit button is pressed the game will close
        Debug.Log("quit");
        Application.Quit();
    }
}
