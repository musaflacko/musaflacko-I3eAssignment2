/******************************************************************************
Author: Wei Feng
Name of Class: Collectible
Description of Class: To make sure that collectibles are being stored and interacted
Date Created: 10/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    public AudioSource collectSound;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        ScoringSystem.theScore += 1;
        collectSound.Play();
        Destroy(gameObject);
    }
}
