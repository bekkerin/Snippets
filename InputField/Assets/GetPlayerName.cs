// this script is attached to the Playername Inputfield. The code in Displayname() executes in the On Value Changed method so every time another character is entered, the string variable and text of Showname are updated.
// we make myPlayerName string static so it can be used in the next scene.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName;
    public static string myPlayerName;
    public Text ShowName;



    public void DisplayName()
    {
        myPlayerName = PlayerName.text; // assign input to string
        ShowName.text = myPlayerName; //assign string to textbox
    }
}
