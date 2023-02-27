//this script is attached to the speed dropdown. Use the On Value CHanged event in the dropdown component.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedSelect : MonoBehaviour
{
    public Dropdown SpeedDropdown;
    public static float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseSpeed()
    {
        switch (SpeedDropdown.value)
        {
            case 1:
                speed = 0.25f;
                break;
            case 2:
                speed = 0.5f;
                break;
            case 3:
                speed = 1.0f;
                break;
            default: // speed if no item is selected. in this case, the player does not move
                speed = 0.0f;
                break;
        }

    }
}
