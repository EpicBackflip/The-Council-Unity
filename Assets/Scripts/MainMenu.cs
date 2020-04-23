using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Playgame()
    {
        Loader.Load(Loader.Scenes.inGame);

    }
public void Tutorial()
    {
        Loader.Load(Loader.Scenes.tutorial);
    }

public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
