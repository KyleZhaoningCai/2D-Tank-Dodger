using UnityEngine;
using System.Collections;

public class StatController : MonoBehaviour {
    private static StatController _instance;
    public static StatController Instance { get { return _instance ?? (_instance = new StatController()); } }

    // PUBLIC INSTANCES VARIABLES (can only be set by this class) +++++
    public int points { get; private set; }
    public string life { get; private set; }
    public int playerLife { get; private set; }
    public bool gameOver { get; private set; }

    // CONSTRUCTOR -- Initialize game stats
    private StatController()
    {
        this.points = 0;
        this.playerLife = 5;
        this.life = "Life: 5";
        gameOver = false;
    }

    // Add newScoreValue points to the points variable
    public void AddScore(int newScoreValue)
    {
        this.points += newScoreValue;
    }

    // Reduce player's lives by 1 and modify the life information or game over information
    public void ReduceLife()
    {
        this.playerLife -= 1;

        // if player has no more life, game is over
        if (this.playerLife <= 0)
        {
            this.life = "Game Over! Press 'R' to Start Over!";
        }
        else
        {
            this.life = "Life: " + this.playerLife;
        }
    }

    // Reset the game stats
    public void Reset()
    {
        this.points = 0;
        this.playerLife =5;
        this.life = "Life: 5";
    }

    // Set the game state to be over or ready
    public void GameOver()
    {
        this.gameOver = !this.gameOver;
    }

}
