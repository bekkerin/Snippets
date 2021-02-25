using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class practicewriting01 : MonoBehaviour
{
    public InputField writeToFile;

    public void WriteString()

    {
        string path = "Assets/Resources/test.txt";

        string dataToBeWritten = writeToFile.text;

        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(dataToBeWritten);
        writer.Close();

        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("test");

        Debug.Log("Finished writing with Method 1.");
    }
    // Start is called before the first frame update
   
}
