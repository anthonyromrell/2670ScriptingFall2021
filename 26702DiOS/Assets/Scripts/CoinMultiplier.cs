using UnityEngine;

[CreateAssetMenu]
public class CoinMultiplier : ScriptableObject
{
    public IntData coins;
    
    public void MultiplyCoin(int num)
    {
        coins.value *= num;
    }
}
