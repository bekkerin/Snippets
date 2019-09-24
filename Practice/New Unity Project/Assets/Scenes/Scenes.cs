using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Game");
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
        UnityEditor.EditorApplication.isPlaying = false;
    }
        
    

}



