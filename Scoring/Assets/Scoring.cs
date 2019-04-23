using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Scoring : MonoBehaviour
{
    static public int newScore = 0;
    public Text NewScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = PlayerName.playerName + ' ' + newScore.ToString();
    }

    public void DecreaseScore() // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = PlayerName.playerName + ' ' + newScore.ToString();
    }
}
