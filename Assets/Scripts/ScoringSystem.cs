using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoringSystem : MonoBehaviour
{
    [SerializeField]
    public GameObject scoreText;

    [SerializeField]
    public int theScore;
    public AudioSource collectSound;

    private void OnTriggerEnter(Collider other)
    {
        //collectSound.Play();
        theScore += 1;
        scoreText.GetComponent<Text>().text = "Coins: " + theScore + "/5";
        collectSound.Play();
        Destroy(gameObject);
    }
}
