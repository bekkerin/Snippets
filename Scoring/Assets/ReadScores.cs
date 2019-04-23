using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;


public class ReadScores : MonoBehaviour
{
    public Text OldScores;
    // attach this script to camera so it is executed on load
    // Start is called before the first frame update
   public void ReadFile()
    {
        string path = "Assets/scores.txt";
        string playerRecord; // string of lines in file
        string[] fields;
        string playerName ; // first field in each line
        int playerScore ; // second field in each line

        StreamReader sr = new StreamReader(path);

        int x = 0; // keep track of index

        while (!sr.EndOfStream)
        {
            playerRecord = sr.ReadLine();
            fields = playerRecord.Split(',');
            Debug.Log(playerRecord);
            playerName = fields[0];
            playerScore = Convert.ToInt32(fields[1]);
            Debug.Log(playerName + playerScore.ToString());
        }
        sr.Close();


    }

}
