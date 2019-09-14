using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    Play,
    Pause,
    GameOver
}

public class GameControl : MonoBehaviour
{
    public GameState gameState;
    Pause pause;
    private float timer;

    private void Start()
    {
        timer = 1f;
        pause = FindObjectOfType<Pause>();
        gameState = GameState.Play;
    }

    private void Update()
    {
        Time.timeScale = timer;

        if(pause.pauseBool == true)
        {
            gameState = GameState.Pause;
            timer = 0f;
        }
        else
        {
            gameState = GameState.Play;
            timer = 1f;
        }
    }
}
