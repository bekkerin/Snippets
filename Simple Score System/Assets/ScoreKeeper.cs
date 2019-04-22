using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreKeeper : MonoBehaviour
{
    static public int newScore = 0;
    public Text NewScore;

    public void IncreaseScore() // clicking on + button increases score
    {
        newScore += 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
    }

    public void DecreaseScore() // clicking on - button decreases score
    {
        newScore -= 1;
        NewScore.text = newScore.ToString();
        Debug.Log(newScore);
    }
 
}
