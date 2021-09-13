using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void AddToValue(float num)
    {
        value += num;
    }

    public void ResetValue(float num)
    {
        value = num;
    }

    public void AddToValueZero(float num)
    {
        if (value <= 0)
        {
            value = 0;
        }
        else
        {
            value += num;
        }
    }
}
