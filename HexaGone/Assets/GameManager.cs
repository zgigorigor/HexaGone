using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    public static float MoveSpeed = 500f;
    public static int Lives = 3;


    public void GameOver()
    {
        // TODO:
        // pause screen prije restarta na kojem piše final score
        //Invoke("Restart", restartDelay);
        //Debug.Log("Game Over!!!!!!!!!!!");
        FindObjectOfType<GameOverMenu>().GameOverScreen();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
