using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Possessions : MonoBehaviour
{
    //A static method can be invoked without an object
    //of a class. Note that static methods cannot access
    //non-static member variables.
    public static int Add(int weapons, int coins)
    {
        return weapons + coins;
    }
}