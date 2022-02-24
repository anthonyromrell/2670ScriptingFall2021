using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public MethodOverloading methodOverloadingObj;
    public void UpdateValue(int obj)
    {
        value += obj;
        methodOverloadingObj.ChangeValue(1,2 );
        var num = methodOverloadingObj.ChangeValue(1, 2);
    }

    public void ResetValue(int obj)
    {
        value = obj;
    }
}