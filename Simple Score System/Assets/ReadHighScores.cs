using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO; // for file reading
using UnityEngine.UI; // for use of UI elements
using System; // so we can use Convert.ToInt32()

// attached to main camera in scene 1

public class ReadHighScores : MonoBehaviour
{
    public Text HighScores; // text field showing high scores

    // Start is called before the first frame update
    void Start()
    {
        GetHighScores();
    }

    void GetHighScores()
    {
        string path = "Assets/scores.txt"; // file with the high scores. Initially empty.
        string playerScore; // line in file with name and score
        string[] fields; // fields in the line
        string playerName; // first field in the fields array
        int score; // second field in the fields array, need to convert to int with Convert.ToInt32()

        // read the lines from the scores.txt file
        StreamReader reader = new StreamReader(path);
        while(!reader.EndOfStream)
        {
            playerScore = reader.ReadLine();  //record is a full line
            fields = playerScore.Split(','); // split fields at comma and read into array
            playerName = fields[0]; // first field is name
            score = Convert.ToInt32(fields[1]);
            HighScores.text += playerName + " : " + score.ToString() + "\n";
        }
        reader.Close();

    }

}
