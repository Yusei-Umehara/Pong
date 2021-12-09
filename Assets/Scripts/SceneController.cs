using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Controls;
    public GameObject Options;
    public GameObject Credits;

    void Start()
    {

    }
    void Update()
    {

    }

    public void changeScene(string name)
    {
        Ganar.Instance.winScreenDisactivate1();
        Ganar.Instance.winScreenDisactivate2();
        print("cambiando a la escena: " + name);
        SceneManager.LoadScene(name);
        GameObject.Find("Ball2").SetActive(false); // Cargar escena genericamente + parametro 

    }

    public void Return2Menu()
    {
        Ganar.Instance.winScreenDisactivate1();
        Ganar.Instance.winScreenDisactivate2();

        SceneManager.LoadScene("Menu");
        GameObject.Find("Ball2").SetActive(true); // Metodo inverso

    }

    public void PlayAgain() 
    {
        Ganar.Instance.winScreenDisactivate1();
        Ganar.Instance.winScreenDisactivate2();
        print("Volver jugar partida");
        SceneManager.LoadScene("Game");
        GameObject.Find("Ball2").SetActive(false);

    }


    public void PlayAgainCPU()
    {
        Ganar.Instance.winScreenDisactivate1();
        Ganar.Instance.winScreenDisactivate2();
        print("Volver jugar partida vs CPU__AI...");
        SceneManager.LoadScene("CPU");
        GameObject.Find("Ball2").SetActive(false);

    }

    public void optionsMenu()
    {
        //GameObject.Find("MainScreen").SetActive(false);  // Desactivar MainScreen, tambien se puede con enabled pero requiere una variable.
        MainMenu.SetActive(false);
        Options.SetActive(true);
        
    }
    public void returnSceneOptions() 
    {
        MainMenu.SetActive(true);
        Options.SetActive(false);
    }

    public void controlsMenu()
    {
        Controls.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void returnSceneControls()
    {
        MainMenu.SetActive(true);
        Controls.SetActive(false);
    }


    public void creditsMenu()
    {
        Credits.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void returnSceneCredits() 
    {
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }


}
