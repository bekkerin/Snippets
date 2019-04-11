using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownSelect : MonoBehaviour
{
    // this script is attached to the manager, but could be attached to any gameobject that has an update method.
    public Dropdown MyDropDown;
    public Text MyChoice;

    // Update is called once per frame
    public void ShowChoice()
    {
        switch(MyDropDown.value)
        {
            case 1:
                MyChoice.text = "Slow";
                break;
            case 2:
                MyChoice.text = "Medium";
                break;
            case 3:
                MyChoice.text = "Fast";
                break;
            default:
                MyChoice.text = "Please Select";
                break;
        }
    }
}
