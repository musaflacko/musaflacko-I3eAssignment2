using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadingFill : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    
    
    public void SetLoad(int load)
    {
        slider.value = load;
    }


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
