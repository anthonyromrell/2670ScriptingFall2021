using UnityEngine;

[CreateAssetMenu]
public class Purchasable : ScriptableObject
{
    public int value;
    [SerializeField] private bool unlocked;
    [SerializeField] private bool purchased;
    
    public bool Unlocked
    {
        get => unlocked;
        set => unlocked = value;
    }
    public bool Purchased
    {
        get => purchased;
        set => purchased = value;
    }
}