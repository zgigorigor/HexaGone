using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int lives = 1;
    public int score;
    public int finalScore;
    //public int destroyedHexagon;

    public Text scoreText;
    public Text livesText;
    public Text finalScoreText;

    public void LoseLife(int l = 1)
    {
        lives -= l;
        if(lives <= 0)
        {
            Time.timeScale = 0f;
            Debug.Log("Lost all lives");
            //FindObjectOfType<GameManager>().GameOver();
            FindObjectOfType<GameOverMenu>().GameOverScreen();
            finalScore = score;
            Debug.Log("Final score: " + finalScore);
            //finalScoreText.text = "Your final score is: " + finalScore.ToString();
        }
    }

    // TODO:
    // dodavanje života za svakih 10 bodova
    //
    //public void GainLife()
    //{
    //    // dodati život
    //    Debug.Log("destroyed hexangos: " + destroyedHexagon);
    //    if (destroyedHexagon >= 10)
    //    {
    //        Debug.Log("extra life added!");
    //        FindObjectOfType<Hexagon>().destroyedHexa = 0;
    //    }
    //    // ispisati poruku da je dobio život
    //    Debug.Log("You've earned another life!");
    //}

    void Update()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
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
