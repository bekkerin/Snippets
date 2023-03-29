// https://sushanta1991.blogspot.com/2015/02/how-to-write-data-to-csv-file-in-unity.html

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System;

public class CsvReadWrite : MonoBehaviour
{
    private List<string[]> rowData = new List<string[]>(); // create a list of string arrays and call it rowData

    // Start is called before the first frame update
    void Start()
    {
        Save(); // call the Save method in this script   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Save()
    {
        // create first row of titles manually
        string[] rowDataTemp = new string[3];
        rowDataTemp[0] = "Name";
        rowDataTemp[1] = "ID";
        rowDataTemp[2] = "Income";
        rowData.Add(rowDataTemp);

        // You can add up the values in as many cells as you want.
        for (int i = 0; i < 10; i++)
        {
            rowDataTemp = new string[3];
            rowDataTemp[0] = "Sushanta" + i; // name
            rowDataTemp[1] = "" + i; // ID
            rowDataTemp[2] = "$" + UnityEngine.Random.Range(5000, 10000); // Income
            rowData.Add(rowDataTemp);
        }


        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = ",";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        string filePath = "Assets/CSV/Saved_data.csv";

        StreamWriter outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();
    }

    
}

