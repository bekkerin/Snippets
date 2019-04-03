using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]  //so we can save it to a file
public class PlayerData 
{
    public int score;
    public string name;

    public PlayerData(Player player)// constructor
    {
        score = player.playerScore;//from the player class
        name = player.playerName;
    }
}
