/******************************************************************************
Author: Wei Feng
Name of Class: Background Music Volume
Description of Class: To be able have a background music during gameplay as well
                    as being able to adjust them.
Date Created: 15/7/21
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMVolume : MonoBehaviour
{

    public AudioSource BGM;
    public Slider slider;
    Text percentageText;
    // Start is called before the first frame update
    void Start()
    {
        percentageText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        BGM.volume = slider.value;
    }

    public void textUpdate (float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}
