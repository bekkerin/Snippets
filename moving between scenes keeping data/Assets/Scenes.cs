using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public static string PlayerName;
    public Text showPlayerName;
    public void StartPlay()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
