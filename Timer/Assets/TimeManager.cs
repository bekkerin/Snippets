using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;

    public float timelimit = 30.0f;
    public float timeRemaining ;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timelimit;

        timeLimitText.text = "time limit: " + timelimit.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if(timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "game over";
        }

    }
}
