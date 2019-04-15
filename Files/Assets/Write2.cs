using UnityEngine;
using UnityEditor;
using System.IO;
using UnityEngine.UI;
// https://docs.microsoft.com/en-us/dotnet/api/system.io.file.readalllines?view=netframework-4.7.2

public class Write2 : MonoBehaviour
{
    public InputField writeToFile;

    public void WriteString2()//NEED TO MAKE THIS PUBLIC SO WE CAN CONNECT TO BUTTON
    {
        string path = "Assets/Resources/test.txt";
        //string path = @"c:\temp\MyTest.txt";

        // get text from the inputfield
        string dataToBeWritten = writeToFile.text;

        // This text is added only once to the file.
        if (File.Exists(path))
        {
            // IN CASE WE WANT TO WRITE MULTIPLE LINES.
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

