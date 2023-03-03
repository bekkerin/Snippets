using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNameNext : MonoBehaviour
{
    public Text NameText;

    // Update is called once per frame. Easy to use Update so we don't have to do anything special to show the name.
    void Update()
    {
        NameText.text = GetPlayerName.myPlayerName;
    }
}
