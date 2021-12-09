using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Manager : MonoBehaviour
{
    public GameObject lofi;
    public GameObject electro;
    public GameObject lofiButton;
    public GameObject electroButton;
    public static bool electronCounter;
    public static int lofiCounter = 0, electroCounter = 0;

    public static Music_Manager instancia; // Singleton
    //AudioSource _audioSource;

    public void lofiOn() // 10
    {       
        if(lofiCounter<=0)
        {
            lofiButton.SetActive(true);
            electroButton.SetActive(false);
            Instantiate(lofi);
            lofiCounter = 1;
            electroCounter = 0;
            Destroyer_electro.instancia.destroyElectro();

        }
    }

    public void electroOn() //01
    {
        if(electroCounter<=0)
        {
            lofiButton.SetActive(false);
            electroButton.SetActive(true);
            Instantiate(electro);
            lofiCounter = 0;
            electroCounter = 1;
            Destroyer_lofi.instancia.destroyLofi();

        }
    }

    public void MusicOff()
    {      
        Destroyer_lofi.instancia.destroyLofi();
        lofiCounter = 0;

    }

    public void electroOff()
    {
        Destroyer_electro.instancia.destroyElectro();
        electroCounter = 0;
    }


    private void Awake()
    {
        if (Music_Manager.instancia == null)
        {
            Music_Manager.instancia = this;
            DontDestroyOnLoad(gameObject);
            
        }
        else
        {
            // Destroy(gameObject); // gameObject en minuscula es referencia al mismo Object de este script.
        }
    }

    void Start()
    {

    }

    void Update()
    {
        
    }
}
