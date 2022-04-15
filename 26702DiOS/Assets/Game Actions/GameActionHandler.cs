using System;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameAction;
    public UnityEvent respondEvent;
    public UnityEvent respondToObjectEvent;
    private void Awake()
    {
        gameAction.Raise += Respond;
        gameAction.UnityActionWithObj += UnityActionWithObj;
    }

    private void UnityActionWithObj(Object obj)
    {
        if (obj == gameObject)
        {
            respondToObjectEvent.Invoke();
        }
    }

    private void Respond()
    {
        respondEvent.Invoke();
    }
}
