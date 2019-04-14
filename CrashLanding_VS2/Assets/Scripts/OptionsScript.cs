using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsScript : MonoBehaviour
{
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("Returning to main menu...");
    }
}
