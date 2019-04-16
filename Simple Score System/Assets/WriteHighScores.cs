using UnityEngine;
using System.IO; // for file reading
using UnityEngine.UI; // for use of UI elements
using UnityEditor; // so we can update the asset database
using System;


public class WriteHighScores : MonoBehaviour
{
    public Text HighScores; // text field showing high scores

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(ScoreKeeper.newScore); //shows proper transfer of newscore
        WriteScores();
    }

    void WriteScores()
    {
        string path = "Assets/scores.txt"; // file with the high scores. Initially empty.
        string[] fields; // fields in each line
        string playerName; // first field in the fields array
        int score; // second field in the fields array, need to convert to int with Convert.ToInt32()
        bool scoreRecorded = false; // we have not written new score to file yet
 
        string[] playerScores = File.ReadAllLines(path); // array of lines in file with name and score
        Debug.Log(playerScores);
 
        // ReadAllLines automatically closes the file

        StreamWriter writer = new StreamWriter(path); // open the file for writing
      
        foreach(string playerScore in playerScores)
        {

            fields = playerScore.Split(','); // split fields at comma and read into fields array
            playerName = fields[0]; // first field is name
            score = Convert.ToInt32(fields[1]); // second field is score
            if(score < ScoreKeeper.newScore && scoreRecorded == false)
            {
                writer.Write(GetPlayerName.playerName + "," + ScoreKeeper.newScore + "\n"); // before we write the existing score, write the new high score
                HighScores.text += GetPlayerName.playerName + " : " + score.ToString() + "\n"; // also show to user
                scoreRecorded = true;
                Debug.Log(GetPlayerName.playerName + " : " + score.ToString() + "\n");
            }
            writer.Write(playerScore + "\n"); // either way, still write the existing score
            HighScores.text += playerName + " : " + score.ToString() + "\n"; // also show to user
            Debug.Log(playerName + " : " + score.ToString() + "\n");
        }

        writer.Close(); // so we don't lock it for next round

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

    }
}
