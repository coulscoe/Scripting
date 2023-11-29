using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehavior : MonoBehaviour
{
    public UnityEvent startEvent, startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalseEvent;

    public bool CanRun { get; set; }
    public IntData counterNum;
    private WaitForSeconds wfsobj;
    public float seconds = 3.0f;
    private WaitForFixedUpdate wffuObj;

    public void Start()
    {
        wfsobj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }

    public void StartCounting()
    {
        StartCoroutine(Counting());
    }
    
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsobj;
        while (counterNum.value >0)
        { 
            repeatCountEvent.Invoke();
            yield return wfsobj;
            counterNum.value--;
            yield return wfsobj;
        }
        endCountEvent.Invoke();
    }

    public void StartRepeatUntilFalse()
    {
        CanRun = true;
        StartCoroutine(RepeatUntilFalse());
    }
    

   private IEnumerator RepeatUntilFalse()
    {
        while (CanRun)
        {
            yield return wfsobj;
            repeatUntilFalseEvent.Invoke();
        }
    }
}