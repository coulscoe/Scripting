
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehaviour
{
   public ID idObj;
   public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
   public IEnumerator OnTriggerEnter(Collider other)// when collision occurs the function runs
   { 
      var tempObj = other.GetComponent<IDContainerBehavior>();// this gets the component and stores it in tempObj
      if (tempObj == null) //if there is no component, ie ID component then the function doesn't run
         yield break;
      
      var otherID = tempObj.idObj; //the variable is into the temp variable, so it can change for each object
      if (otherID == idObj)//if the object's ID matches the other ID then the matchEvent is invoked
      {
         matchEvent.Invoke();
      }
      else
      {
         noMatchEvent.Invoke();//otherwise noMatchEvent is invoked.
         yield return new WaitForSeconds(0.5f);
         noMatchDelayedEvent.Invoke();
      }
   }
}
