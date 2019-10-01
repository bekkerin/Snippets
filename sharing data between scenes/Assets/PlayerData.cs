using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public InputField NameInput;
    public Text Playername;
    static string playerName;

    public void MyPlayerName()// to execute any time inputfield changes
    {
        playerName = NameInput.text;
        Debug.Log(playerName);
    }

    

}
