/******************************************************************************
Author: Wei Feng
Name of Class: Teleport Player
Description of Class: To bring the player from different places back and forth 
Date Created: 10/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{

    public GameObject loadingscreen;

    public Transform TeleportTarget;

    public GameObject Player;

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
        loadingscreen.SetActive(true);
        Player.transform.position = TeleportTarget.transform.position;
    }
}
