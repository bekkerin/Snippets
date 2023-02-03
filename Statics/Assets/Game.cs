using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    public Text enemyCount;
    public Text playerCount;

    void Start()
    {
        //Enemy enemy1 = new Enemy(); // this is the normal C# syntax but Unity "does not allow it".
        Enemy enemy1 = gameObject.AddComponent<Enemy>();
        //Enemy enemy2 = new Enemy();
        Enemy enemy2 = gameObject.AddComponent<Enemy>();
        //Enemy enemy3 = new Enemy();
        Enemy enemy3 = gameObject.AddComponent<Enemy>();
        //Player player1 = new Player();
        Player player1 = gameObject.AddComponent<Player>();

        //You can access a static variable by using the class name
        //and the dot operator.
        int x = Enemy.enemyCount; // you really can't use x outside this method since it is local to start() only. Better to use Enemy.enemyCount directly in other scripts.
    }
    private void Update()
    {

        enemyCount.text = "Number of enemies: " + Enemy.enemyCount.ToString();
        playerCount.text = "Number of players: " + Player.playerCount.ToString();
    }

    // add an enamy by clicking on the butotn
    public void AddEnemy()
    {
        Enemy.enemyCount++; // use the Enemy class to add an enemy through the AddEnemy method.
    }
}