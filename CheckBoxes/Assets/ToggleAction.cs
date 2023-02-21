using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleAction : MonoBehaviour
{
    public Text MyText;
    public Toggle MyToggle;
    public Camera cam;

    //need to connect to ToggleAction.Toggle_Changed(), not ToggleAction.Toggle_Changed(bool). 
    public void Toggle_Changed(bool newValue)
    {

        if(newValue == false)
        {
            MyText.text = "checkbox off with value " + newValue.ToString() 
                + "\nClick on the checkbox to hear the duck quack.";
            cam.GetComponent<AudioSource>().Pause();
        }
        else
        {
            MyText.text = "checkbox on with value " + newValue.ToString();
            cam.GetComponent<AudioSource>().Play();
        }


    }

}
