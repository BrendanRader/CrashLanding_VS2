using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreboardScript : MonoBehaviour
{
    public GameObject ScoreboardUI;
    public GameObject WinCanvas;

    public void Scoreboard()
    {
        ScoreboardUI.SetActive(true);
        WinCanvas.SetActive(false);
    }
}
