using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionUI : MonoBehaviour
{
    public Collection collection;

    public void StartBuild(Transform obj)
    {
        StartCoroutine(BuildCollectionLayout(obj));
    }
    
    
    public IEnumerator BuildCollectionLayout(Transform obj)
    {
        foreach (var collectable in collection.collectablesList)
        {
            yield return new WaitForSeconds(0.2f);
            var newPanel = Instantiate(collection.layoutObject, obj);
            newPanel.collectableData = collectable;
            newPanel.cash = collection.cash;
        }
    }

    public bool CheckIfCollected(Collectable obj)
    {
        return obj.collected;
    } 
    
    private bool CheckPrice(Collectable obj)
    {
        return obj.price <= collection.cash.value;
    }
}
