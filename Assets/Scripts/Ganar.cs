using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ganar : MonoBehaviour
{
    public GameObject Player1w;
    public GameObject Player2w;

    [SerializeField] public static int winnerPoints = 5;

    private static Ganar instance;
    public static Ganar Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<Ganar>();

            }
            return instance;

        }

    }


    void Start()
    {
        //Player1w.SetActive(false);
        //Player2w.SetActive(false);
        Time.timeScale = 1;
    }

    public void Playerwin()
    {
        if (GameManager.paddle1Score == winnerPoints)
        {
            Player1w.SetActive(true);
            Time.timeScale = 0;
        }
        else if(GameManager.paddle2Score == winnerPoints)
        {
            Player2w.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void winScreenDisactivate1()
    {
        if (GameManager.paddle1Score == winnerPoints)
            Player1w.SetActive(false);

        GameManager.Instance.ballPointsReset();
    }

    public void winScreenDisactivate2()
    {
        if (GameManager.paddle2Score == winnerPoints)
            Player2w.SetActive(false);

        GameManager.Instance.ballPointsReset();
    }

    void Update()
    {
        Playerwin();
    }
}
