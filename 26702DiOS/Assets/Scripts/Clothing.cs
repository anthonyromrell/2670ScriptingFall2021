using UnityEngine;

[CreateAssetMenu]
public class Clothing : ArtBase, IPurchasable
{
   public int stylePoints;
   public bool Purchased { get; set; }
   public int CashValue { get; set; }
}
