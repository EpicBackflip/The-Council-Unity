using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Playgame()
    {
        Loader.Load(Loader.Scenes.MiniGameUitleg);

    }

public void StartKnop()
{
    Loader.Load(Loader.Scenes.MiniGame);

    }
public void Tutorial()
    {
        Loader.Load(Loader.Scenes.Chapter_1);
    }

public void Return()
{
    Loader.Load(Loader.Scenes.menu);
    }

public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
