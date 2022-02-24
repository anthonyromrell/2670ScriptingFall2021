using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Store : ScriptableObject
{
    public List<ScriptableObject> purchaseList;
    private readonly List<IPurchasable> iPurchaseList;

    public Store(List<IPurchasable> iPurchaseList)
    {
        this.iPurchaseList = iPurchaseList;
        UpdateList();
    }
    
    private void UpdateList()
    {
        foreach (var obj in purchaseList)
        {
            iPurchaseList.Add(obj as IPurchasable);
        }
    }
}
