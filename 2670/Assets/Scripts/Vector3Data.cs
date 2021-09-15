using UnityEngine;

[CreateAssetMenu]
public class Vector3Data : ScriptableObject
{
    public Vector3 value;

    public void SetValue(Vector3 num)
    {
        value = num;
    }

    public void SetFromPosition(Transform obj)
    {
        value = obj.position;
    }

    public void SetPositionFromValue(Transform obj)
    {
        obj.position = value;
    }
}
