/******************************************************************************
Author: Wei Feng
Name of Class: Loading Fill
Description of Class: It is the typical loading bar
Date Created: 15/07/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingFill : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    [SerializeField]
    private int Progress;
    public GameObject loadingScreen;
        
    void Start()
    {
        loadingScreen.SetActive(true);
        slider.value = Progress;
    }

    // Update is called once per frame
    void Update()
    {
        loader();
    }

    private void loader()
    {
        if (slider.value != 100)
        {
            slider.value += 50 * Time.deltaTime ;

        }
        else
        {
            loadingScreen.SetActive(false);
            slider.value = 0;
        }

    }
}
