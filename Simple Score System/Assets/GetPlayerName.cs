using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour
{
    public InputField NameField;
    static public string playerName;

    public void GetName()
    {
        playerName = NameField.text;
    }
}
