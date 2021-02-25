using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class practicereading01 : MonoBehaviour
{
    public Text fileContents;

    public void ReadString()

    {
        string path = "Assets/Resources/test.txt";
        string lineRead = "";
        fileContents.text = "";

        StreamReader reader = new StreamReader(path);
        while (!reader.EndOfStream)
        {
            lineRead = reader.ReadLine();
            Debug.Log(lineRead);
            fileContents.text += lineRead + "\n";
               
        }
        reader.Close();
    }
    // Start is called before the first frame update
   
}
