using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNieuwe : MonoBehaviour
{
  
    public  float movementSpeed = 5f;



    // Update is called once per frame
    public void Start()
    {
        

    }
    public void Update()
    {
       
        float inputY = Input.GetAxis("Vertical");
        Debug.Log(inputY);
        transform.position = transform.position + new Vector3(0, inputY - movementSpeed * Time.deltaTime, 0);
        //transform.position.y += inputY * movementSpeed * Time.deltaTime;

        
        


        if (transform.position.y < -10)
        {
            Reset();
        }
        
    }
    public void Reset()
    {
       
        transform.position = new Vector3(Random.Range(-13, 12), Random.Range(10, 15), transform.position.z);
    }
}
