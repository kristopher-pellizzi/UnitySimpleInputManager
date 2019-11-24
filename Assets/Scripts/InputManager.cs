﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Control _control;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        String[] names = Input.GetJoystickNames().Where(joyName => !joyName.Equals("")).ToArray();
        
        if (names.Length == 0)
        {
            _control = Control.Keyboard;
        }
        else if (names[0].Equals("Wireless Controller"))
        {
            _control = Control.Ps4;
        }
        else
        {
            _control = Control.Xbox;
        }
    }

    public static bool GetButtonDown(String name)
    {
        return _control.GetButtonDown(name);
    }

    public static float GetAxis(String name)
    {
        return _control.GetAxis(name);
    }

    public static float GetAxisRaw(String name)
    {
        return _control.GetAxisRaw(name);
    }
}