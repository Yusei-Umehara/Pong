using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBall : MonoBehaviour
{
    public static ColorBall instancia;
    public static Color ballColor = Color.white;

    Rigidbody2D ball2RB;

    [SerializeField] public Transform ball2Transform;


    private void Awake()
    {
        if (ColorBall.instancia == null)
        {
            ColorBall.instancia = this;
            DontDestroyOnLoad(gameObject);
            //ballColor = GetComponent<Color>();

        }
        else
        {
            //Destroy(gameObject); // gameObject en minuscula es referencia al mismo Object de este script.
        }

    }

    public void BallColorWhite()
    {
        GameObject.Find("Ball2").GetComponent<SpriteRenderer>().color = Color.white;
        ballColor = Color.white;
        
    }
    public void BallColorRed()
    {
        GameObject.Find("Ball2").GetComponent<SpriteRenderer>().color = Color.red;
        ballColor = Color.red;
    }
    public void BallColorGreen()
    {
        GameObject.Find("Ball2").GetComponent<SpriteRenderer>().color = Color.green;
        ballColor = Color.green;

    }
    public void BallColorBlue()
    {
        GameObject.Find("Ball2").GetComponent<SpriteRenderer>().color = Color.blue;
        ballColor = Color.blue;

    }


    void Start()
    {
        ball2RB = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        
    }

    public void ReTransforming()
    {
        ball2Transform.position = new Vector3(-243, -148, 22);
        float xVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        float yVelocity = Random.Range(0, 2) == 0 ? 1 : -1;
        ball2RB.velocity = new Vector2(xVelocity, yVelocity) * 4f;
    }
}
