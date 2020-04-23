using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinNieuwe : MonoBehaviour
{
  
    public  float movementSpeed = 5f;
    public Vector3 Velocity = new Vector3(0, 5f, 0);
 

    // Update is called once per frame
    public void Start()
    {
        

    }
    public void Update()
    {
        Debug.Log(transform.position);
        float inputY = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0, inputY * movementSpeed * Time.deltaTime, 0);
        transform.position = transform.position + new Vector3(0, inputY * movementSpeed * Time.deltaTime, 0);
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
