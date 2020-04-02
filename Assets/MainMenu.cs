using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void Playgame()
    {


        SceneManager.LoadScene(2);

    }
public void Tutorial()
    {


        SceneManager.LoadScene(1);
    }

public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
