using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer_electro : MonoBehaviour
{
    public static Destroyer_electro instancia;

    public void destroyElectro()
    {
        Destroy(gameObject);
    }


    void Start()
    {
        if (Destroyer_electro.instancia == null)
        {
            Destroyer_electro.instancia = this;
            DontDestroyOnLoad(gameObject);

        }
        else
            Destroy(gameObject);


    }

    void Update()
    {
        
    }
}
