using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction unityAction;
        
    public void Raise ()
    {
        unityAction?.Invoke();
    }
}
