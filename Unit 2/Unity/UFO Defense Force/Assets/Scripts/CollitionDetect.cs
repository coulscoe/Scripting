using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollitionDetect : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
       Destroy(gameObject); // destroy this game object
       Destroy(other.gameObject);// destroy the other game object it hits
   }
}
