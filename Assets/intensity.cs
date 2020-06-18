using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intensity : MonoBehaviour {
    bool yes = false;
    bool no = false;
    // Start is called before the first frame update
    void Start()
    {
        Light light = GetComponent<Light>();
        light.intensity = 100f;
    }
    public void ButtonYes()
        {
        bool yes = true;
        
        }
    public void ButtonNo()
    {
        bool no = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (yes == true) 
        {
            GetComponent<Light>().intensity = GetComponent<Light>().intensity * 1.5f;
            yes = false;
            Debug.Log("yes");
        }
        else if(no == true)
        {
            GetComponent<Light>().intensity = GetComponent<Light>().intensity * 0.5f;
            no = false;
            Debug.Log("no");
        }
    }


}
