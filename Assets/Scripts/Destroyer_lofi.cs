using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_lofi : MonoBehaviour
{
    public static Destroyer_lofi instancia;

    public void destroyLofi()
    {
        Destroy(gameObject);
    }


    void Start()
    {
        if (Destroyer_lofi.instancia == null)
        {
            Destroyer_lofi.instancia = this;
            DontDestroyOnLoad(gameObject);

        }
        else
            Destroy(gameObject);


    }

    void Update()
    {
        
    }
}
