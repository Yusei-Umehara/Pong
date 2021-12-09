using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float iaSpeed = 7f; // Velocidad de la IA 

    public GameObject ball;

    private Vector2 ballPos;

    void Update()
    {
        Move();
  
    }

    void Move()
    {
        ballPos = ball.transform.position;

        if (transform.position.y > ballPos.y)
        {
            transform.position += new Vector3(0, -iaSpeed*Time.deltaTime, 0);
        }

        if (transform.position.y < ballPos.y)
        {
            transform.position += new Vector3(0, +iaSpeed * Time.deltaTime, 0);
        }


    }

}
