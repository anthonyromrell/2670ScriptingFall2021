using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Store : ScriptableObject
{
    public List<ScriptableObject> purchaseList;
    private List<IPurchasable> purchasables;

    private void OnEnable()
    {
        purchasables = new List<IPurchasable>();
        foreach (var obj in purchaseList)
        {
            purchasables.Add(obj as IPurchasable);
        }
    }
}
