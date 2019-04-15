using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public string playerName;
    public int playerScore;
    public float playerHandicap;

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
        Debug.Log("saved");

    }

    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        playerScore = data.score;
        playerName = data.name;
        playerHandicap = data.handicap;
        //Debug.Log("loaded");
        Debug.Log(playerName + " " + playerScore + " " + playerHandicap);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerScore += 1;
            Debug.Log(playerScore);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerScore -= 1;
            Debug.Log(playerScore);
        }
    }

}
