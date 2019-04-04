using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
// https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=netframework-4.7.2

public class Read2 : MonoBehaviour
{
    public Text fileContents;

    public void ReadString2() //NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/Resources/test.txt";

        // In case we want to use appending of text.
        //string appendText = "This is extra text" + "\n";
        //File.AppendAllText(path, appendText);

        fileContents.text = ""; // clear the text on screen

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            fileContents.text += s + "\n"; // append and go to new line
        }
    }

}

