using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Playgame()
    {
        Loader.Load(Loader.Scenes.SchuldInput);

    }
public void Tutorial()
    {
        Loader.Load(Loader.Scenes.Chapter_1);
    }

public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
