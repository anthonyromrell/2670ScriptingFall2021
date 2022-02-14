using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject, IPurchasable
{
    public int powerLevel;
    public Sprite art;
    private bool purchased;
    private int cashValue;

    public bool Purchased
    {
        get => purchased;
        set => purchased = value;
    }

    public int CashValue
    {
        get => cashValue;
        set => cashValue = value;
    }
}
