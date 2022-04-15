using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction Raise { get; set; }
    public UnityAction<Object> UnityActionWithObj { get; set; }
}
