using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Dropdown SpeedDropdown;
    public Text ColorText;
    public GameObject PlayerCapsule;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        PlayerCapsule.GetComponent<Renderer>().material.color = Color.black;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorDropdown.value)
        {
            case 1:
                ColorText.text = ColorDropdown.options[1].text;
                PlayerCapsule.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                ColorText.text = ColorDropdown.options[2].text;
                PlayerCapsule.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 3:
                ColorText.text = ColorDropdown.options[3].text;
                PlayerCapsule.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                ColorText.text = ColorDropdown.options[0].text;
                PlayerCapsule.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
    public void ChooseSpeed()
    {
        switch (SpeedDropdown.value)
        {
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            default:

                break;
        }

    }
}
