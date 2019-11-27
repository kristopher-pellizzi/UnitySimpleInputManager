using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var os = Environment.OSVersion.Platform;
        switch (os)
        {
            case PlatformID.Win32S:
            case PlatformID.Win32Windows:
            case PlatformID.Win32NT:
            case PlatformID.WinCE:
                print("I'm using Windows");
                break;
            case PlatformID.MacOSX:
                print("I'm using MacOS");
                break;
            default:
                print("I'm using Linux");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Buttons test
        if (InputManager.GetButtonDown("Button0"))
        {
            print("Button 0 pressed");
        }
        if (InputManager.GetButtonDown("Button1"))
        {
            print("Button 1 pressed");
        }
        if (InputManager.GetButtonDown("Button2"))
        {
            print("Button 2 pressed");
        }
        if (InputManager.GetButtonDown("Button3"))
        {
            print("Button 3 pressed");
        }
        if (InputManager.GetButtonDown("Button4"))
        {
            print("Button 4 pressed");
        }
        if (InputManager.GetButtonDown("Button5"))
        {
            print("Button 5 pressed");
        }
        if (InputManager.GetButtonDown("Button6"))
        {
            print("Button 6 pressed");
        }
        if (InputManager.GetButtonDown("LB"))
        {
            print("LB pressed");
        }
        if (InputManager.GetButtonDown("RB"))
        {
            print("RB pressed");
        }
        if (InputManager.GetButtonDown("LAnalog"))
        {
            print("Left analog pressed");
        }
        if (InputManager.GetButtonDown("RAnalog"))
        {
            print("Right analog pressed");
        }
        
        // Axis test
        if (InputManager.GetAxisRaw("Horizontal") > 0.1)
        {
            print("Left analog moved to right");
        }
        else if (InputManager.GetAxisRaw("Horizontal") < -0.01)
        {
            print("Left analog moved to left");
        }
        if (InputManager.GetAxisRaw("Vertical") > 0.01)
        {
            print("Left analog moved upwards");
        }
        else if (InputManager.GetAxisRaw("Vertical") < -0.01)
        {
            print("Left analog moved downwards");
        }
        if (InputManager.GetAxisRaw("RHorizontal") > 0.01)
        {
            print("Right analog moved to right");
        }
        else if (InputManager.GetAxisRaw("RHorizontal") < -0.01)
        {
            print("Right analog moved to left");
        }
        if (InputManager.GetAxisRaw("RVertical") > 0.01)
        {
            print("Right analog moved upwards");
        }
        else if (InputManager.GetAxisRaw("RVertical") < -0.01)
        {
            print("Right analog moved downwards");
        }
        if (InputManager.GetAxisRaw("DPadHorizontal") > 0.01)
        {
            print("Directional Pad pressed to right");
        }
        else if (InputManager.GetAxisRaw("DPadHorizontal") < -0.01)
        {
            print("Directional Pad pressed to left");
        }
        if (InputManager.GetAxisRaw("DPadVertical") > 0.01)
        {
            print("Directional Pad pressed up");
        }
        else if (InputManager.GetAxisRaw("DPadVertical") < -0.01)
        {
            print("Directional Pad pressed down");
        }
        if (InputManager.GetAxisRaw("LTrigger") > 0.01)
        {
            print("Left trigger pulled");
        }
        if (InputManager.GetAxisRaw("RTrigger") > 0.01)
        {
            print("Right trigger pulled");
        }

        if (Input.GetAxisRaw("Ps4RHorizontal") > 0.01)
        {
            print("ANALOG DESTRO A DESTRA");
        }
    }
}
