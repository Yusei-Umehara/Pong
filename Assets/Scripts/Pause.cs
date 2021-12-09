using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    bool active;
    Canvas canvasPause;

    void Start()
    {
        canvasPause = GetComponent<Canvas>();
        canvasPause.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) || Input.GetKeyDown(KeyCode.P))
        {
            active = !active;
            canvasPause.enabled = active;
            Time.timeScale = (active) ? 0 : 1f; 
                        

        }
    }

    public void unPause()
    {
        active = !active;
        canvasPause.enabled = active;
        Time.timeScale = (active) ? 0 : 1f;

    }

}
