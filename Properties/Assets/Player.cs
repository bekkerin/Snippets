using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int experience;

    public int Experience
    {
        get
        {
            return experience;
        }
        set
        {
            experience = value;
        }
    }

    //Lives is a property that converts experience
    //points into the lives of a player automatically
    public int Lives
    {
        get
        {
            return 1 + experience / 10;
        }
        set
        {
            experience = (value * 10) -1 ;
        }
    }

    //This is an example of an auto-implemented
    //property. The value is automatically set at 0
    // but can change in code
    public int Health { get; set; }
}

