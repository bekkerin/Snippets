using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Scenes : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene("2Scoring");
    }
    public void DonePlaying()
    {
        SceneManager.LoadScene("3ShowNewHighScores");
    }
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

}
