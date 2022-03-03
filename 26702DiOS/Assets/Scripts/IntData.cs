using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
   
    public void UpdateValue(int obj)
    {
        value += obj;
    }

    public void ResetValue(int obj)
    {
        value = obj;
    }
}