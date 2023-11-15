using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public IntData counterNum;
    private WaitForSeconds wfsobj;
    public float seconds = 3.0f;
    private WaitForFixedUpdate wffuObj;
    IEnumerator Start()
    {
        
        wfsobj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        
        startEvent.Invoke();
        yield return wfsobj;
        while (counterNum.value >0)
        { 
            repeatEvent.Invoke();
            counterNum.value--;
            yield return wfsobj;
           
        }
        endEvent.Invoke();
    }
}
