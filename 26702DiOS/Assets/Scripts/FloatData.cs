using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float value;

    public float Value
    {
        get => value;
        set => this.value = value;
    }

    public void UpdateValue(float num) => Value += num;
}
