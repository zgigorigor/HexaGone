using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit game!");
        Application.Quit();
    }

    public void GameOverMenu()
    {
        Debug.Log("Game over menu activated");
        //SceneManager.LoadScene(SceneManager.GetSceneByName(GameOverMenu).buildIndex);
    }
}
