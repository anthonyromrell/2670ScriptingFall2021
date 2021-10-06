using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    public bool canRun = true;
    public float holdTime = 2f;
    private WaitForSeconds wfs;

    public void StartCoroutineSimple()
    {
        StartCoroutine(CoroutineSimple());
    }
    
    private IEnumerator CoroutineSimple()
    {
        wfs = new WaitForSeconds(holdTime);
        
        while (canRun)
        {
            yield return wfs;
            startEvent.Invoke();
        }
    }
    public void ChangeWaitTime(float time)
    {
        wfs = new WaitForSeconds(time);
    }

    public void StartCoroutineWithIncrease()
    {
        StartCoroutine(CoroutineWithIncrease());
    }
    
    private IEnumerator CoroutineWithIncrease()
    {
        wfs = new WaitForSeconds(holdTime);

        while (canRun)
        {
            yield return wfs;
            if (holdTime >= 0.1f)
            {
                holdTime -= 0.1f;
                wfs = new WaitForSeconds(holdTime);
            }
            startEvent.Invoke();
        }
    }
}