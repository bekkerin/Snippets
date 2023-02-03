using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string weapon;
    public int lives;

    //The first Add method adds a weapon as a string
    public void Add(string weapon)
    {
        Debug.Log("Enemy got a " + weapon);
    }

    //The second Add method adds lives as an int
    public void Add(int lives)
    {
        Debug.Log("Enemy got another " + lives + " lives.");
        Debug.Log("Enemy got another " + lives + " lives.");
    }
}
