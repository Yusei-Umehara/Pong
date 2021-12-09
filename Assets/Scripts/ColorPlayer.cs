using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlayer : MonoBehaviour
{
    public static ColorPlayer instancia;
    public static Color colorPlayer1 = Color.white;
    public static Color colorPlayer2 = Color.white;


    void Start()
    {
        if (ColorPlayer.instancia == null)
        {
            ColorPlayer.instancia = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            //Destroy(gameObject); // gameObject en minuscula es referencia al mismo Object de este script.
        }
    }


    void Update()
    {
        
    }
    public void PlayerColorWhite1()
    {
        //GameObject.Find("ColorPlayer").GetComponent<SpriteRenderer>().color = Color.white;
        colorPlayer1 = Color.white;

    }
    public void PlayerColorRed1()
    {
        colorPlayer1 = Color.red;
    }
    public void PlayerColorGreen1()
    {
        colorPlayer1 = Color.green;

    }
    public void PlayerColorBlue1()
    {
        colorPlayer1 = Color.blue;

    }

                                 // PLAYER 2
    public void PlayerColorWhite2()
    {
        colorPlayer2 = Color.white;
    }
    public void PlayerColorRed2()
    {
        colorPlayer2 = Color.red;
    }
    public void PlayerColorGreen2()
    {
        colorPlayer2 = Color.green;
    }
    public void PlayerColorBlue2()
    {
        colorPlayer2 = Color.blue;
    }




}
