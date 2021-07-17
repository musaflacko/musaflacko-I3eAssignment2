/******************************************************************************
Author: Elyas Chua-Aziz
Name of Class: DemoPlayer
Description of Class: This class will control the movement and actions of a player avatar based on user input.
Date Created: 09/06/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SamplePlayer : MonoBehaviour
{
    /// <summary>
    /// The distance this player will travel per second.
    /// </summary>
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private float rotationSpeed;

    public AudioSource Footstep;

    /// <summary>
    /// The camera attached to the player model.
    /// Should be dragged in from Inspector.
    /// </summary>
    [SerializeField]
    private Camera playerCamera;

    private string currentState;

    private string nextState;

    [SerializeField]
    private float interactionDistance;

    // Start is called before the first frame update
    void Start()
    {
        nextState = "Idle";
    }

    // Update is called once per frame
    void Update()
    {
        if(nextState != currentState)
        {
            SwitchState();
        }

        CheckRotation();
        InteractionRaycast();
    }

    /// <summary>
    /// Sets the current state of the player
    /// and starts the correct coroutine.
    /// </summary>
    private void SwitchState()
    {
        StopCoroutine(currentState);

        currentState = nextState;
        StartCoroutine(currentState);
    }

    private IEnumerator Idle()
    {
        while(currentState == "Idle")
        {
            if(Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
            {
                nextState = "Moving";
                Footstep.Play();
            }
            yield return null;
        }
    }

    private IEnumerator Moving()
    {
        while (currentState == "Moving")
        {
            if (!CheckMovement())
            {
                nextState = "Idle";
                Footstep.Stop();
            }
            yield return null;
        }
    }

    private void CheckRotation()
    {
        Vector3 playerRotation = transform.rotation.eulerAngles;
        playerRotation.y += Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(playerRotation);

        Vector3 cameraRotation = playerCamera.transform.rotation.eulerAngles;
        cameraRotation.x -= Input.GetAxis("Mouse Y") * rotationSpeed * Time.deltaTime;

        playerCamera.transform.rotation = Quaternion.Euler(cameraRotation);
    }

    /// <summary>
    /// Checks and handles movement of the player
    /// </summary>
    /// <returns>True if user input is detected and player is moved.</returns>
    private bool CheckMovement()
    {
        Vector3 newPos = transform.position;

        Vector3 xMovement = transform.right * Input.GetAxis("Horizontal");
        Vector3 zMovement = transform.forward * Input.GetAxis("Vertical");

        Vector3 movementVector = xMovement + zMovement;

        if(movementVector.sqrMagnitude > 0)
        {
            movementVector *= moveSpeed * Time.deltaTime;
            newPos += movementVector;
            transform.position = newPos;

            return true;
        }
        else
        {
            return false;
        }

    }

    private void InteractionRaycast()
    {
        Debug.DrawLine(playerCamera.transform.position, playerCamera.transform.position + playerCamera.transform.forward * interactionDistance);

        int door = 1 << LayerMask.NameToLayer("Door");

        //int keydoor = 1 << LayerMask.NameToLayer("Keydoor");

        int flashlight = 1 << LayerMask.NameToLayer("Flashlight");


        RaycastHit hitinfo;
        if(Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitinfo, interactionDistance, door))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                hitinfo.transform.GetComponent<InteractableObject>().DoorAnimation();
            }
        }

        /*if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitinfo, interactionDistance, keydoor))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hitinfo.transform.GetComponent<KeyDoor>().Gone();
            }

        }*/

        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hitinfo, interactionDistance, flashlight))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                hitinfo.transform.GetComponent<PickUpLight>().Activate();
            }
        }

    }
}
