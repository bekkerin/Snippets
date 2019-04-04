using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;

public class Write1 : MonoBehaviour
{
    public InputField writeToFile;
 
    public  void WriteString()//NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/Resources/test.txt";

        // get text from the inputfield
        string dataToBeWritten = writeToFile.text;

        //Write some text to the test.txt file
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine(dataToBeWritten);
        writer.Close();

        //Re-import the file to update the reference in the editor
        AssetDatabase.ImportAsset(path);
        TextAsset asset = (TextAsset)Resources.Load("test"); // NEED TO CAST AS A TEXT ASSET SO IT CAN BE USED. TRY WITHOUT.

        //Print the text from the file
        Debug.Log("done writing with method 1");
    }

}


