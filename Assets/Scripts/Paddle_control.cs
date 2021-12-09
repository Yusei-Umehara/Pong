using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle_control : MonoBehaviour
{

    [SerializeField] private float speed = 8f;
    [SerializeField] private bool isPaddle1;
    private float yBound = 3.75f;

    void Start() // Cambiar color
    {
        applyPlayerColor1();
        applyPlayerColor2();

    }

    void Update()
    {
        float movement;

        if (isPaddle1) // == true
        {
            movement = Input.GetAxisRaw("Vertical2"); // w and s

        }
        else
        {
            movement = Input.GetAxisRaw("Vertical"); // up and down
        }

        //transform.position += new Vector3(0, movement * speed * Time.deltaTime, 0);
        Vector2 paddlePosition = transform.position;
        paddlePosition.y = Mathf.Clamp(paddlePosition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = paddlePosition;

        

    }


    public static void applyPlayerColor1()
    {
        GameObject.Find("Paddle2").GetComponent<SpriteRenderer>().color = ColorPlayer.colorPlayer1;
    }
    public static void applyPlayerColor2()
    {
        GameObject.Find("Paddle1").GetComponent<SpriteRenderer>().color = ColorPlayer.colorPlayer2;
    }

}
