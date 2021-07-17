/******************************************************************************
Author: Wei Feng
Name of Class: Quit Game
Description of Class: To quit the game once the button is pressed in the main menu
Date Created: 16/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Debug.Log("QuitGame");
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
