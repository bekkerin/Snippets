using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEditor;

public class practicewriting02 : MonoBehaviour
{
    public InputField writeToFile;

    public void WriteString2()
    {
        string path = "Assets/Resources/test.txt";

        string dataToBeWritten = writeToFile.text;

        if (File.Exists(path))
        {
            string[] createText = { "Written with method 2", dataToBeWritten };
            File.WriteAllLines(path, createText);

        }
        else
        {
            Debug.Log("File does not exist");
        }

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("test");
    }
}
