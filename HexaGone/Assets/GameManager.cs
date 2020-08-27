using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;

    public void GameOver()
    {
        Debug.Log("Game Over!!!!!!!!!!!");
        // TODO:
        // pause screen prije restarta na kojem piše final score
        //FindObjectOfType<MainMenu>().GameOverMenu();
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
