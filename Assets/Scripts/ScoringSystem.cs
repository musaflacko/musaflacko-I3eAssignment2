/******************************************************************************
Author: Musa & Wei Feng
Name of Class: Scoring System 
Description of Class: To keep track of the score system when the game is played
Date Created: 11/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    [SerializeField]
    public GameObject scoreText;

    [SerializeField]
    public GameObject scoreText2;

    [SerializeField]
    public GameObject Quest2;

    [SerializeField]
    public static int theScore;

    private void Update()
    {
        checkScore();
    }

    private void checkScore()
    {
        if(theScore != 5)
        {
            scoreText.GetComponent<Text>().text = "Coins: " + theScore + "/5";
        }
        else
        {
            scoreText.SetActive(false);
            theScore = 0;
            scoreText2.SetActive(true);
            gameObject.SetActive(false);
            Quest2.SetActive(true);

        }

    }
}
