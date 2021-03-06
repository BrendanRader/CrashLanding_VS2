﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource source;
    public AudioClip continueClip;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
       source = GetComponent<AudioSource>();
    }

    void Update()
    {
       if (Input.GetKey("escape"))
            Application.Quit();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level1.2");
        Debug.Log("Loading Level1...");
        source.PlayOneShot(continueClip);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
        Debug.Log("Going to the options...");
        source.PlayOneShot(continueClip);
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
        source.PlayOneShot(continueClip);
    }

    public void PlayerObjectives()
    {
        SceneManager.LoadScene("PlayerObjectives");
        Debug.Log("Going to player objectives...");
        source.PlayOneShot(continueClip);
    }

    public void WinLoseConditions()
    {
        SceneManager.LoadScene("WinLoseConditions");
        Debug.Log("Going to the Win/Lose conditions...");
        source.PlayOneShot(continueClip);
    }

    public void Scoreboard()
    {
        SceneManager.LoadScene("Scoreboard");
        Debug.Log("Loading Scoreboard 1...");
        source.PlayOneShot(continueClip);
    }

    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");
        Debug.Log("Loading Level 2...");
        source.PlayOneShot(continueClip);
    }

    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");
        Debug.Log("Loading Level 3...");
        source.PlayOneShot(continueClip);
    }

    public void Credits()
    {
        SceneManager.LoadScene("Credits");
        Debug.Log("Loading Credits...");
        source.PlayOneShot(continueClip);
    }
}
