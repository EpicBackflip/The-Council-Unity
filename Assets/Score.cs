using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Text scoreText;
    public int CoinScore = 0;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = CoinScore.ToString();
        
    }
}
