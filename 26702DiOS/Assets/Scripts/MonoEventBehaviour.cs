using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    public void Start()
    {
        startEvent.Invoke();
    }
}