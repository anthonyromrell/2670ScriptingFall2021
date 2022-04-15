using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    [SerializeField] private int value;

    public int Value
    {
        get => value;
        set => this.value = value;
    }

    public void UpdateValue(int num)
    {
        Value += num;
    }

    public void UpdateValueZeroCheck(int num)
    {
        UpdateValue(num);
        CheckZeroValue();
    }

    public void ResetValue(int obj)
    {
        Value = obj;
    }

    public void CheckZeroValue()
    {
        if (Value <= 0)
        {
            Value = 0;
        }
    }
}