using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_Sound : MonoBehaviour
{
    public float tiempoVida;

    void Start()
    {
        Destroy(gameObject, tiempoVida);   
    }

    void Update()
    {
        
    }
}
