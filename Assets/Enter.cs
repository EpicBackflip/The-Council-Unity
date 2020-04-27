using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public void OnClick()
    {

        Loader.Load(Loader.Scenes.MiniGame);

    }


    void Update()
    {

    }
}
