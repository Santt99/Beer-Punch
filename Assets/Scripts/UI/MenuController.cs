using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer soundsMixer;
    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }
    public void SetMusicVolume(float volume)
    {
        musicMixer.SetFloat("volume", volume);
    }

    public void SetSoundsVolume(float volume)
    {
        soundsMixer.SetFloat("volume", volume);
    }

    public void SetGraphics(float graphicsLevel)
    {
        QualitySettings.SetQualityLevel((int)graphicsLevel);
    }

}
