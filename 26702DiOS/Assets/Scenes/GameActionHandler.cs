using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameAction;
    public UnityEvent respondEvent;
    private void Awake()
    {
        gameAction.unityAction += Respond;
    }

    private void Respond()
    {
        respondEvent.Invoke();
    }
}
