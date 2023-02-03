using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script is attached to the camera - remember that the camera always exists so that can be useful
// check for output in the debug log in the console

public class Game : MonoBehaviour
{       

    void Start()
    {
        // Enemy myEnemy = new Enemy(); // deprecated in Unity
        Enemy myEnemy = gameObject.AddComponent<Enemy>();


        //The specific Add method called will depend on
        //the arguments passed in.
        myEnemy.Add("gun"); // add a weapon
        myEnemy.Add(2); // add two lives
    }
}