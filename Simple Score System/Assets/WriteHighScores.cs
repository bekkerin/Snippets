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
        string allData; // holds all data in the file
        string[] playerScores; // lines that hold name and score
        string[] fields; // fields in each line
        string playerName; // first field in the fields array
        int score; // second field in the fields array, need to convert to int with Convert.ToInt32()
        bool scoreRecorded = false; // we have not written new score to file yet
<<<<<<< HEAD

        StreamReader reader = new StreamReader(path); //open file for reading
        allData = reader.ReadToEnd(); // read all data into single string
        reader.Close();
        playerScores = allData.Split('\n'); // load the array of lines with names and scores

=======
 
        string[] playerScores = File.ReadAllLines(path); // array of lines in file with name and score
 
        // ReadAllLines automatically closes the file
>>>>>>> parent of 323bbfd... snippets

        StreamWriter writer = new StreamWriter(path); // open the file for writing
      
        foreach(string playerScore in playerScores)
        {
            /*
            fields = playerScore.Split(','); // split fields at comma and read into fields array
            playerName = fields[0]; // first field is name
            score = Convert.ToInt32(fields[1]); // second field is score
            if(score < ScoreKeeper.newScore && scoreRecorded == false)
            {
                writer.Write("Ernst" + "," + ScoreKeeper.newScore + "\n"); // before we write the existing score, write the new high score
                HighScores.text += "Ernst" + " : " + score.ToString() + "\n"; // also show to user
                scoreRecorded = true; 
            }
            writer.Write(playerScore + "\n"); // either way, still write the existing score
            HighScores.text += playerName + " : " + score.ToString() + "\n"; // also show to user
<<<<<<< HEAD
            Debug.Log(playerName + " : " + score.ToString() + "\n");
            */
=======
>>>>>>> parent of 323bbfd... snippets
        }

        writer.Close(); // so we don't lock it for next round

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");
  
    }
}
