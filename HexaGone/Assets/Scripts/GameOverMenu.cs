using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMenu : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject gameOverUI;

    int livesLeft;

    // Update is called once per frame
    //void Update()
    //{
    //    livesLeft = FindObjectOfType<ScoreManager>().lives;
    //    Debug.Log("from GOM: lives left: " + livesLeft);
    //    if (livesLeft <= 0)
    //    {
    //        //GetComponent<GameManager>().GameOver();
    //        GameOverScreen();
    //    }
    //}

    public void GameOverScreen()
    {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }

    public void ResumeGame()
    {
        Debug.Log("from GOM: resume game");
    }

    public void BackToMainMenu()
    {
        Debug.Log("from GOM: back to main menu");
    }
}
