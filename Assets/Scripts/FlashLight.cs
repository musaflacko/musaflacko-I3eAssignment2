using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{

    public GameObject flashLight;
    public AudioSource clickOn;
    public AudioSource clickOff;
    public bool isOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switchLight();
    }

    private void switchLight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn == false)
            {
                flashLight.SetActive(true);
                clickOn.Play();
                isOn = true;
            }
            else
            {
                flashLight.SetActive(false);
                clickOff.Play();
                isOn = false;
            }
        }
    }
}
