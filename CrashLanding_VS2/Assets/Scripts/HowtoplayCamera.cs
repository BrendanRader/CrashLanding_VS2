using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HowtoplayCamera : MonoBehaviour
{
    public void BackGame()
    {
        SceneManager.LoadScene("HowtoplayAlien");
        Debug.Log("Going to previous page...");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Returning to main menu...");
    }
}
