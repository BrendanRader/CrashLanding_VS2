using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Loading Level1...");
    }

    public void QuitGame()
    {
        Debug.Log("The game is quitting...");
        Application.Quit();
    }

    public void HowtoplayGame()
    {
        SceneManager.LoadScene("HowtoplayAlien");
        Debug.Log("Going to game instructions...");
    }

    public void PlayerObjectives()
    {
        SceneManager.LoadScene("PlayerObjectives");
        Debug.Log("Going to player objectives...");
    }

    public void WinLoseConditions()
    {
        SceneManager.LoadScene("WinLoseConditions");
        Debug.Log("Going to the Win/Lose conditions...");
    }
}
