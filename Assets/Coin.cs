using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float gravityScale;
    //public Rigidbody2D RB;
    public Vector3 Velocity = new Vector3(0,0.0000000001f,0);
    
    //Random random = new Random();

    void Update()
    {
        Debug.Log(transform.position);
        //transform.position += Velocity;
        //Debug.Log(transform.position);
        if (transform.position.y < -10)
        {
            Reset();
        }
    }

    void Reset()
    {
        //Debug.Log(RB.velocity);
        transform.position = new Vector3(Random.Range(-13, 12), Random.Range(10, 15), transform.position.z);
       
        //RB.gravityScale = 0.1f;
       //RB.velocity = new Vector2(0, 0.5f);
    }
}
