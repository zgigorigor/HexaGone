using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int lives = GameManager.Lives;
    public int score;
    int destroyedHexa;
    public static int finalScore;

    public Text scoreText;
    public Text livesText;
    public Text finalScoreText;

    public int LoseLife(int l = 1, int s = 1)
    {
        lives -= l;
        score -= s;
        return lives;
    }

    public void GainingLife()
    {
        destroyedHexa += 1;
        if ( destroyedHexa >= 10 )
        {
            GetLife();
            destroyedHexa = 0;
        }
    }

    public int GetLife(int l = 1)
    {
        lives += l;
        return lives;
    }

    public void CheckLife()
    {
        if(lives <= 0)
        {
            Time.timeScale = 0f;
            FinalScore();
            FindObjectOfType<GameManager>().GameOver();
        }
    }

    public int FinalScore()
    {
        finalScore = score;
        return finalScore;
    }

    void Update()
    {
        CheckLife();
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
        //FinalScore();
        //scoreText.text = "SCORE: " + score.ToString();
        //if (lives == 1)
        //{
        //    livesText.text = lives.ToString() + " LIFE";
        //}
        //else
        //{
        //    livesText.text = lives.ToString() + " LIVES";
        //}

        // TODO:
        // prikaz broja života
        
    }

}
