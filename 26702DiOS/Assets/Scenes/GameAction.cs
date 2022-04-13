using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction unityAction;
    public UnityAction<Object> unityActionWithObj;

    public void Raise ()
    {
        unityAction?.Invoke();
    }

    public void Raise(Object obj)
    {
        unityActionWithObj(obj);
    }
}
