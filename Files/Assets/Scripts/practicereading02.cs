using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class practicereading02 : MonoBehaviour
{
    public Text fileContents;

    public void ReadString2()
    {
        string path = "Assets/Resources/test.txt";

        fileContents.text = "";

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            fileContents.text += s + "\n";
        }
    }
}
