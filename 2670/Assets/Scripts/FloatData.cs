using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void AddToValue(float num)
    {
        value += num;
    }
}
