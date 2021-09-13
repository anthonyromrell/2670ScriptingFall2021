using System;
using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, destroyEvent;
    void Start()
    {
        startEvent.Invoke();        
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }
}