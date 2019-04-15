using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]  //so we can save it to a file
public class PlayerData 
{
    // THIS SCRIPT IS WHERE WE NEED TO SET THE ATTRIBUTES
    public int score = 100;
    public string name ;
    public float handicap;

    public PlayerData(Player player)// constructor
    {
        score = player.playerScore;//from the player class
        name = player.playerName;
        handicap = player.playerHandicap;
    }

private void Update()
{
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
        score += 1;
        Debug.Log(score);
    }
    if (Input.GetKeyDown(KeyCode.DownArrow))
    {
        score -= 1;
        Debug.Log(score);
    }
}

}
