/******************************************************************************
Author: Wei Feng
Name of Class: Loading Screen
Description of Class: To load the game smoothly into the next scene
Date Created: 10/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void ExitGame()
    {
        Debug.Log("ExitGame");
        Application.Quit();
    }
}
