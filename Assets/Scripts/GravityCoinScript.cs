using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityCoinScript : MonoBehaviour
{
    public float gravityScale;
    public Rigidbody2D Rb;
    //Random random = new Random();

    void Update()
    {
        Debug.Log(transform.position);
        if (transform.position.y < -10)
        {

            transform.position = new Vector3(Random.Range(-13, 12), Random.Range(10, 15), transform.position.z);
            Rb.gravityScale = 0;
        }
    }
}
