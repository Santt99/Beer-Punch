using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public KeyCode keyToPause;
    public Canvas pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(keyToPause))
        {

            PauseMenuController();
        }
    }

    public void PauseMenuController()
    {
        if (!pauseMenu.enabled)
        {
            StartCoroutine(activatePM(3));
        }
        else
        {
            ActivateOrDesactivatePauseMenu();
        }
    }
    public void ActivateOrDesactivatePauseMenu()
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
    IEnumerator activatePM(float seconds)
    {

        yield return new WaitForSecondsRealtime(seconds);
        ActivateOrDesactivatePauseMenu();
    }
}
