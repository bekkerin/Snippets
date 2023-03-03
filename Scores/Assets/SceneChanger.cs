using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ToWriting()
    {
        SceneManager.LoadScene("Writing Scores");
    }
    public void ToReading()
    {
        SceneManager.LoadScene("Reading Scores");
    }
}
