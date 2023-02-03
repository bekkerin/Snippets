using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public Button increaseButton;
    public Player player;
    public Text livesText;
    public Text experienceText;
    public Text healthText;

    void Start()
    {
        player = new Player();

        //Properties can be used just like variables
        player.Experience = 5;
    }
    private void Update()
    {
        experienceText.text = "Experience: " + player.Experience.ToString();
        livesText.text = "Lives: " + player.Lives.ToString();
        if (player.Experience > 7)
            player.Health = 1;
        if (player.Experience > 14)
            player.Health = 2;
        healthText.text = "Health: " + player.Health.ToString();
    }
    public void IncreaseExperience()
    {
        player.Experience += 1;
    }
}