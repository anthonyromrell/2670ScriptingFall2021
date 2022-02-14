using System;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent respondEvent;
    private void Awake()
    {
        gameActionObj.unityActionObj += Respond;
    }

    private void Respond()
    {
        respondEvent.Invoke();
    }
}
