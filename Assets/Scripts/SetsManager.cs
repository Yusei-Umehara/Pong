using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetsManager : MonoBehaviour
{
    public static int bestOf;

    public static SetsManager instancia; // Singleton Persistente

    private void Awake()
    {
        if (SetsManager.instancia == null)
        {
            SetsManager.instancia = this;
            DontDestroyOnLoad(gameObject);
            //ballColor = GetComponent<Color>();

        }
        else
        {
            Destroy(gameObject); // gameObject en minuscula es referencia al mismo Object de este script.
        }

    }

    public void BestofNoLimits()
    {
        bestOf = -1;
        Ganar.winnerPoints = bestOf;
    }
    public void Bestof5()
    {   
        bestOf = 5;
        Ganar.winnerPoints = bestOf;
    }
    public void Bestof10()
    {
        bestOf = 10;
        Ganar.winnerPoints = bestOf;
    }
    public void Bestof15()
    {
        bestOf = 15;
        Ganar.winnerPoints = bestOf;
    }




    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
