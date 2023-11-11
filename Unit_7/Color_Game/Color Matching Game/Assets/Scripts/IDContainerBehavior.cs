using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDContainerBehavior : MonoBehaviour
{
   public ID idObj;//contains the ID of an object
   public UnityEvent startEvent;

   public void Start()
   {
      startEvent.Invoke();
   }
}
