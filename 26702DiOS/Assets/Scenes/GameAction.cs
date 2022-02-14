using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction unityActionObj;
        
    public void Raise ()
    {
        unityActionObj?.Invoke();
    }
}
