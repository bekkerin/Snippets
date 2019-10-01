using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN All THE SCENES

public class KeepData: MonoBehaviour 
{
    // STATIC so they are preserved between classes
    public static string PlayerName; 
    public static int PlayerLives;
    public static float PlayingSpeed;

    public InputField PlayerNameInput;
    public Slider speedSlider;
    //lives are hard coded

    public Text showPlayerName; // don't forget to drop the hierarchy objects in the script slots in the inspector
    public Text showPlayerLives;
    public Text playingSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    private void Update() //I left my timestamp on so you see that it updates in real time
    {
        Debug.Log(PlayerName + " has " + PlayerLives + " lives and " + PlayingSpeed + " speed.");
    }
    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }
    public void ShowName() //method for the show name button on intro
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void SetLives() //method for clicking on "give 10 lives" button on intro
    {
        PlayerLives = 10;
        showPlayerLives.text = PlayerLives.ToString() + " lives";
        Debug.Log(PlayerLives + " given");
    }
    public void ShowLives() //method for show lives button on game screen
    {
        showPlayerLives.text = PlayerLives.ToString() + " lives";
        Debug.Log("lives: " + PlayerLives);
    }

    public void SetSpeed() //method for the slider on intro screen
    {
        PlayingSpeed = speedSlider.value;
        playingSpeedText.text = PlayingSpeed.ToString();
    }
    public void ShowSpeed() // method for clicking on playing speed button on game screen 
    {
        playingSpeedText.text = PlayingSpeed.ToString();
        speedSlider.value = PlayingSpeed; // you use the speed value here

    }
    public void ChangeSpeed() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingSpeed = speedSlider.value; // change to the new value from game screen slider
        playingSpeedText.text = speedSlider.value.ToString(); //show updated value
    }
    public void DieOnce() // click event for Die Once button
    {
        PlayerLives -= 1; //one less life to live
        showPlayerLives.text = PlayerLives.ToString() + " lives";
        Debug.Log("lives: " + PlayerLives);
    }
    /*
     * change background - inspector for camera, from skybox to solid color
     * for transfer data: attach a script (like "KeepData") to an empty game object (like "DataManager")
     * public static (data type) (variable name);
     * if you get the value from a control, make the control public: public (UI element) (UI name)  AND LOAD THE OBJECT TO THE BOX IN THE INSPECTOR
     * create the DataManager with the KeepData script in all scenes including introduction and exit screens
     * 
     */

}
