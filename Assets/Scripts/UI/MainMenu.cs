using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
public class MainMenu : MonoBehaviour
{
    
    public void QuitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void StartGame(){
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
   
    }
    public void Settings(){
        SceneManager.LoadScene("SettingsMenu", LoadSceneMode.Single);
     
    }
}
