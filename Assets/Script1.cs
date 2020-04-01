using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public Transform Square;
    Renderer m_Renderer;

    void Start() 
    {
        m_Renderer = GetComponent<Renderer>();
        Debug.Log(Square.position.x);
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            float touchX = touchPosition.x;
            float touchY = touchPosition.y;

            if (touchX >= Square.position.x &&
                touchX <= Square.position.x + Square.localScale.x &&
                touchY >= Square.position.y &&
                touchY <= Square.position.y + Square.localScale.y)

            {
                m_Renderer.material.color = Color.red;
            }

            else
            {
                m_Renderer.material.color = Color.white;
            }
        }
    }
}
