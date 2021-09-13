using UnityEngine;
using UnityEngine.Events;
public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}