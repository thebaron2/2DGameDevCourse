﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // cached references
    GameSession gameStatus;
 
    public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
        gameStatus = FindObjectOfType<GameSession>();
        gameStatus.ResetGame();


    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
