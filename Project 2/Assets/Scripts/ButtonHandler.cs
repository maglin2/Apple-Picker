using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit."); //to test in editor
    }
    public void startGame()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void highScores()
    {
        SceneManager.LoadScene("HighScores");
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainScene");
    }
}
