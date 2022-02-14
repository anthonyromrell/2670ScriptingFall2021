using UnityEngine;
using UnityEngine.Events;

public class CircleBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    
    void Start()
    {
        startEvent.Invoke();
    }
}