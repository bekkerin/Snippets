using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System; // for date and time

public class Pause : MonoBehaviour
{
    public Text timeText;
    public Button resumeButton;
    private bool isPaused = false;


    // Start is called before the first frame update
    void Start() // show the time when the game starts. Resume button is set to inactive as game starts.
    {
        timeText.text = "Time: " + DateTime.Now.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // ESC key pauses AND resumes
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        if (!isPaused) // need to do this to show change in time, Update() always works. 
        {
            timeText.text = "Time: " + DateTime.Now.ToString();
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
        timeText.text = "Game is paused";
        resumeButton.gameObject.SetActive(true); // show the Resume button
    }
    public void ResumeGame() // called from ESC; also attached to the resume button
    {
        Time.timeScale = 1;
        isPaused = false;
        timeText.text = "Time: " + DateTime.Now.ToString();
        resumeButton.gameObject.SetActive(false); // hide the Resume button while playing
    }

}
