using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;
using UnityEditor;

public class WriteScores : MonoBehaviour
{
    public Text HighScores;
    public InputField NewScore;
    public InputField NewName;
    public int num_scores = 5;

    public void AddNewScore()
    {
        string path = "Assets/scores.txt";
        string line;
        string[] fields;
        int scores_written = 0;
        string newName = "don't forget to input";
        string newScore = "999";
        bool newScoreWritten = false;
        string[] writeNames = new string[5];
        string[] writeScores = new string[5];

        HighScores.text = ""; // clear the scores box
        newName = NewName.text;
        newScore = NewScore.text;

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream )
        {
            line = reader.ReadLine();
            fields = line.Split(',');
            if (!newScoreWritten && scores_written < num_scores) // if new score has not been written yet
            {
                //check if we need to write new higher score first
                if(Convert.ToInt32(newScore) > Convert.ToInt32( fields[1]))
                {
                    HighScores.text += newName + " : " + newScore + "\n";
                    writeNames[scores_written] = newName;
                    writeScores[scores_written] = newScore;
                    newScoreWritten = true;
                    scores_written += 1;
                }

            }
            if(scores_written < num_scores) // we have not written enough lines yet
            {
                HighScores.text += fields[0] + " : " + fields[1] + "\n";
                writeNames[scores_written] = fields[0];
                writeScores[scores_written] = fields[1];
                scores_written += 1;
            }
        }
        reader.Close();

        // now we have parallel arrays with names and scores to write
        StreamWriter writer = new StreamWriter(path);

        for(int x = 0; x < scores_written; x++)
        {
            writer.WriteLine(writeNames[x] + ',' + writeScores[x]);
        }
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("scores");

    }
}
