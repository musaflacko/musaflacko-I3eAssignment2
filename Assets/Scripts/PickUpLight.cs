using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpLight : MonoBehaviour
{

    public GameObject Light;
    public AudioSource flashlight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Activate()
    {
        Light.SetActive(true);
        flashlight.Play();
        gameObject.SetActive(false);
    }
}
