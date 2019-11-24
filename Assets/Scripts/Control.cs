using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public enum Control
{
   Xbox,
   Ps4,
   Keyboard
}

public static class ControlExtensions
{
   private static ControlManager[] _managers = {new ControlManager().Initialize(Control.Xbox), new ControlManager().Initialize(Control.Ps4), new ControlManager().Initialize(Control.Keyboard)};

   private static int GetManagerID(Control c)
   {
      switch (c)
      {
         case Control.Xbox:
            return 0;
         case Control.Ps4:
            return 1;
         default:
            return 2;
      }
   }

   public static bool GetButtonDown(this Control c, String name)
   {
      return _managers[GetManagerID(c)].GetButtonDown(name);
   }

   public static float GetAxis(this Control c, String axis)
   {
      return _managers[GetManagerID(c)].GetAxis(axis);
   }

   public static float GetAxisRaw(this Control c, String axis)
   {
      return _managers[GetManagerID(c)].GetAxisRaw(axis);
   }

   private class ControlManager
   {
      private Dictionary<String, String> _input;

      public ControlManager Initialize(Control c)
      {
         String prefix;
         switch (c)
         {
            case Control.Xbox:
               prefix = "Xbox";
               break;
            case Control.Ps4:
               prefix = "Ps4";
               break;
            default:
               prefix = "KB";
               break;
         }
         
         _input = new Dictionary<string, string>();
         // Buttons
         _input.Add("Button0", prefix + "0");
         _input.Add("Button1", prefix + "1");
         _input.Add("Button2", prefix + "2");
         _input.Add("Button3", prefix + "3");
         _input.Add("Button4", prefix + "4");
         _input.Add("Button5", prefix + "5");
         _input.Add("Button6", prefix + "6");
         _input.Add("LB", prefix + "LB");
         _input.Add("RB", prefix + "RB");
         _input.Add("LAnalog", prefix + "LAnalog");
         _input.Add("RAnalog", prefix + "RAnalog");
         // Axis
         _input.Add("Horizontal", prefix + "LHorizontal");
         _input.Add("Vertical", prefix + "LVertical");
         _input.Add("RHorizontal", prefix + "RHorizontal");
         _input.Add("RVertical", prefix + "RVertical");
         _input.Add("DPadHorizontal", prefix + "DPadHorizontal");
         _input.Add("DPadVertical", prefix + "DPadVertical");
         _input.Add("LTrigger", prefix + "LT");
         _input.Add("RTrigger", prefix + "RT");

         return this;
      }
      
      public bool GetButtonDown(String name)
      {
         _input.TryGetValue(name, out var button);
         return Input.GetButtonDown(button);
      }

      public float GetAxis(String name)
      {
         _input.TryGetValue(name, out var axis);
         return Input.GetAxis(axis);
      }

      public float GetAxisRaw(String name)
      {
         _input.TryGetValue(name, out var axis);
         return Input.GetAxisRaw(axis);
      }
   }
}
