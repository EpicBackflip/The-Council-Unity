using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newCoin : MonoBehaviour
{
    public Score score;
    public SchuldInput schuldinput;
    public  float movementSpeed = 5f;
    public bool isHit; 

    // Update is called once per frame
    public void Start()
    {
        

    }
    public void Update()
    {
        
        float inputY = Input.GetAxis("Vertical");
        
        transform.position = transform.position + new Vector3(0, inputY - movementSpeed * Time.deltaTime, 0);
        //transform.position.y += inputY * movementSpeed * Time.deltaTime;

        if (transform.position.y < -10)
        {
            Reset();
        }
        
    }
    public void Reset()
    {
        isHit = false; 
        transform.position = new Vector3(Random.Range(-13, 12), Random.Range(10, 15), transform.position.z);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hit");

        isHit = true; 
        score.CoinScore++;

        Reset();

        /*
        if(col.gameObject.name == "coinBank")
        {
            Debug.Log("check");
            Reset();

        }
        */

    }
}
