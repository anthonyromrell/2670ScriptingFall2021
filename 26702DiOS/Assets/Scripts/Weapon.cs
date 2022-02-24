using UnityEngine;

[CreateAssetMenu]
public class Weapon : ArtBase, IPurchasable
{
    public int powerLevel;
    public GameObject fxArt;

    public void Fire()
    {
        Debug.Log("Fire");
    }

    public bool Purchased { get; set; }
    public int CashValue { get; set; }
}
