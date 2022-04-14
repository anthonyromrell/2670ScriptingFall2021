using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public IntData cash;
    public CollectablePanelBehaviour layoutObject;
    public List<Collectable> collectablesList;

    public void BuildCollectionLayout(Transform obj)
    {
        foreach (var collectable in collectablesList)
        {
            var newPanel = Instantiate(layoutObject, obj);
            newPanel.collectableData = collectable;
            newPanel.cash = cash;
        }
    }

    public bool CheckIfCollected(Collectable obj)
    {
        return obj.collected;
    } 
    
    private bool CheckPrice(Collectable obj)
    {
        return obj.price <= cash.value;
    }
}
