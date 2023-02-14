using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public bool flashlightOn = false;
    public Light light;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            light.enabled = !light.enabled;
            flashlightOn = !flashlightOn;
        }
    }
}
