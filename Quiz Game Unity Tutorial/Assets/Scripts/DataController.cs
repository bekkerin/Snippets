using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// in File / Build Settings, import Scenes/persisitent, Scenes/MenuScreen, and Scenes/Game

public class DataController : MonoBehaviour //attached to data controller
{
    public RoundData[] allRoundData;  // array of all data in all rounds

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad( gameObject); // objects from previous scenes are NOT destroyed. 
        SceneManager.LoadScene("MenuScreen");
        
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData[0]; // only data for index 0. later on we can pass it arry 1 and so on.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
