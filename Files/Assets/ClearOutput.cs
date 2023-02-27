using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearOutput : MonoBehaviour
{
    public Text fileContents;

    public void Clear()
    {
        fileContents.text = "";
        Debug.Log("output cleared");
    }
}
