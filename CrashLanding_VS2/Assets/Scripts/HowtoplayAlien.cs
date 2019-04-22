using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowtoplayAlien : MonoBehaviour
{
    public void BackGame()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Returning to main menu...");
    }

    public void NextGame()
    {
        SceneManager.LoadScene("PlayerObjectives");
        Debug.Log("Going to next page...");
    }
}
