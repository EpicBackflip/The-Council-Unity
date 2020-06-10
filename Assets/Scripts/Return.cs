using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    public void OnClick()
    {
        Loader.Load(Loader.Scenes.menu);
    }
}
