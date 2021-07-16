using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    [SerializeField]
    public GameObject scoreText1;
    public GameObject scoreText2;

    [SerializeField]
    public int theScore;
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        theScore += 1;
        scoreText1.GetComponent<Text>().text = "Coins: " + theScore + "/5";
        collectSound.Play();
        Destroy(gameObject);
        checkScore();
    }


    public void checkScore()
    {
        if (theScore == 5)
        {
            scoreText1.SetActive(false);
            scoreText2.SetActive(true);
        }
    }
}
