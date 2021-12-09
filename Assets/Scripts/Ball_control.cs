using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_control : MonoBehaviour
{
    private Rigidbody2D ballRB;
    [SerializeField] private float initialVelocity = 4f;
    [SerializeField] private float velocitiMultiplier = 1.1f;
    public GameObject sonidoPaddle;
    public GameObject sonidoWall;
    public GameObject sonidoGoal;

    void Start()
    {

        ballRB = GetComponent<Rigidbody2D>();

        StartCoroutine("Esperar");

        applyColor();


    }

    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(3);
        Launch();
    }

    public void applyColor()
    {
        GameObject.Find("Ball").GetComponent<SpriteRenderer>().color = ColorBall.ballColor;
    }

    public void Launch()
    {
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ballRB.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity; 

    }

    private void OnCollisionEnter2D(Collision2D collision) // Chocar vs PALETA
    {
        if (collision.gameObject.CompareTag("paddle"))
        {
            ballRB.velocity *= velocitiMultiplier;
            actSonidoPaddle();
            //gameObject.GetComponent<AudioSource>().Play();
        }
        else if (collision.gameObject.CompareTag("Wall"))   // Chocar vs Pared
        {
            actSonidoWall();
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))  // Chocar vs Meta
        {
            GameManager.Instance.paddle2Scored();
            actSonidoGoal();
            GameManager.Instance.Restart();
            Launch();
            // Insertar metodo de player 2 gano

        }
        else                                          
        {
            GameManager.Instance.paddle1Scored();
            actSonidoGoal();
            GameManager.Instance.Restart();
            Launch();
            // Insertar metodo de player 1 gano:

        }

    }

    // SONIDOS
    public void actSonidoPaddle()
    {
        Instantiate(sonidoPaddle);
        //Destroy(sonidoPaddle);
    }
    public void actSonidoWall()
    {
        Instantiate(sonidoWall);
    }
    public void actSonidoGoal()
    {
        Instantiate(sonidoGoal);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            applyColor();
            print("Cambio de color exitoso");

        }
        else if (Input.GetKeyDown(KeyCode.D))
            actSonidoPaddle();

    }


}
