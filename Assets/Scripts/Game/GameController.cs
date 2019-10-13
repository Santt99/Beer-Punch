using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public KeyCode keyToPause;
    public Canvas pauseMenu;
    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(keyToPause))
        {
            activateOrDesactivatePauseMenu();
        }
    }

    public void activateOrDesactivatePauseMenu()
    {
        pauseMenu.enabled = !pauseMenu.enabled;
        if (pauseMenu.enabled)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

}
