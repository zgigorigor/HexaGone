using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int lives = 1;
    public int score;

    public Text scoreText;

    public void LoseLife(int l = 1)
    {
        lives -= l;
        if(lives <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    //public void GameOver()
    //{
    //    Debug.Log("Game Over! score manager");
    //    SceneManager.LoadScene(SceneManager.GetActiveScene( ).name);
    //}

    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
