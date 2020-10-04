using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }


    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    // TODO:
    // pauza: resume button
    // game over: restart game button, back to menu button, quit game button


    public void ToMainMenu()
    {
        Debug.Log("to main menu");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        //Application.Quit();
    }
}
