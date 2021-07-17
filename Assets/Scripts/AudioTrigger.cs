/******************************************************************************
Author: Wei Feng
Name of Class: Audio Trigger
Description of Class: To play a sound when triggered to create a scary effect 
Date Created: 16/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{

    public AudioSource scarySound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {       
        scarySound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        scarySound.Stop();
    }
}
