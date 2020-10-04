using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour
{
    public static bool GamePause = false;
    public GameObject gameOverUI;
    public Text finalScoreText;
    public Text finalScoreMessage;
    public int finalScore;


    public void GetFinalScore()
    {
        finalScore = ScoreManager.finalScore;
        finalScoreText.text = finalScore.ToString();

        if ( finalScore == 1)
        {
            finalScoreMessage.text = "HEXAGON DESTROYED";
        }
        else
        {
            finalScoreMessage.text = "HEXAGONS DESTROYED";
        }
    }

    public void GameOverScreen()
    {
        GetFinalScore();
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
