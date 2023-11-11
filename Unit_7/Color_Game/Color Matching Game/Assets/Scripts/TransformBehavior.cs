using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformBehavior : MonoBehaviour
{
   public void RestToZero()
   {
      transform.position = Vector3.zero; 
   }
}
