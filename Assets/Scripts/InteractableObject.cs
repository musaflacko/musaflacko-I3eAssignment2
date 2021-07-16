using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    private Animator doorAnim;

    private bool doorOpen = false;

    public AudioSource openDoor;
    public AudioSource closeDoor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  
    }

    private void Awake()
    {
        doorAnim = gameObject.GetComponent<Animator>();
    }

    public void DoorAnimation()
    {
        if (!doorOpen)
        {
            doorAnim.Play("Door_Open", 0, 0.0f);
            openDoor.Play();
            doorOpen = true;
        }
        else
        {
            doorAnim.Play("Door_Close", 0, 0.0f);
            closeDoor.Play();
            doorOpen = false;
        }
    }
}
