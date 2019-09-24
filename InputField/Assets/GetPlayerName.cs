using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName;
    public string myPlayerName;
    public Text ShowName;

    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayName()
    {
        myPlayerName = PlayerName.text; // assign input to string
        ShowName.text = myPlayerName; //assign string to textbox
    }
}
