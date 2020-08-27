using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;

    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                FindObjectOfType<PauseMenu>().Resume();
            }
            else
            {
                FindObjectOfType<PauseMenu>().Pause();
            }
        }
    }


    public void GameOver()
    {
        Debug.Log("Game Over!!!!!!!!!!!");
        // TODO:
        // pause screen prije restarta na kojem piše final score
        Invoke("Restart", restartDelay);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
