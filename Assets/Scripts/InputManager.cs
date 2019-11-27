using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private static Control _control;

    private OperatingSystemFamily _os;
    // Start is called before the first frame update
    void Start()
    {
        _control = Control.Keyboard;
        _os = SystemInfo.operatingSystemFamily;
        switch (_os)
        {
            case OperatingSystemFamily.Windows:
                print("I'm on Windows");
                break;
            case OperatingSystemFamily.MacOSX:
                print("I'm on Mac OS");
                break;
            default:
                print("I'm on Linux");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Control previous = _control;
        String[] names = Input.GetJoystickNames().Where(joyName => !joyName.Equals("")).ToArray();
        
        if (names.Length == 0)
        {
            _control = Control.Keyboard;
        }
        else if (names[0].Equals("Wireless Controller"))
        {
            switch (_os)
            {
                case OperatingSystemFamily.Windows:
                    _control = Control.Ps4;
                    break;
                case OperatingSystemFamily.MacOSX:
                    _control = Control.MacOsPs4;
                    break;
                default:
                    _control = Control.LinuxPs4;
                    break;
            }
        }
        else
        {
            switch (_os)
            {
                case OperatingSystemFamily.Windows:
                    _control = Control.Xbox;
                    break;
                case OperatingSystemFamily.MacOSX:
                    _control = Control.MacOsXbox;
                    break;
                default:
                    _control = Control.LinuxXbox;
                    break;
            }
        }

        if (_control != previous)
        {
            print(_control);
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

    public static bool GetButtonUp(String name)
    {
        return _control.GetButtonUp(name);
    }

    public static bool GetButton(String name)
    {
        return _control.GetButton(name);
    }
}
