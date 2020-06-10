using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCoin : MonoBehaviour
{
    public Score score;
    public SchuldInput schuldinput;
    public  float movementSpeed = 20f;
    public bool isHit; 

    public void Update()
    {
        // this allows you to modify the Y position of the coin's position
        float inputY = Input.GetAxis("Vertical");
        // this subtracts the movement speed to the vertical position based on time in seconds 
        transform.position = transform.position + new Vector3(0, inputY - movementSpeed * Time.deltaTime, 0);
        // when the coins reach the bottem of the screen reset gets called
        if (transform.position.y < -10)
        {
            Reset();
        }
        
    }
    public void Reset()
    {
        // this resets the position back to the top of the screen with random values
        isHit = false; 
        transform.position = new Vector3(Random.Range(-8, 8), Random.Range(30, 60), transform.position.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        // when the coinbank hits a coin the score goes up and the coin is reset
        isHit = true; 
        score.CoinScore++;
        Reset();
    }
}
