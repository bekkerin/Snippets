using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Static variables are shared across all instances
    //of a class. You start with zero enemies
    public static int enemyCount = 0;

    public Enemy()
    {
        //Increment the static variable to know how many
        //objects of this class have been created.
        enemyCount++;
    }
}
