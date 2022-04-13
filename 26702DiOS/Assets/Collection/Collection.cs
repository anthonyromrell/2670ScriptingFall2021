using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

[CreateAssetMenu]
public class Collection : ScriptableObject
{
    public IntData cash;
    public CollectablePanelBehaviour layoutObject;
    public List<Collectable> collectablesList;

    public void BuildCollectionLayout(Transform obj)
    {
        foreach (var item in collectablesList)
        {
            var newPanel = Instantiate(layoutObject, obj);
            newPanel.image.sprite = item.art;
            newPanel.label.text = item.name;
            newPanel.button.interactable = CheckPrice(item);
            newPanel.buttonLabel.text = "Buy $" + item.price;
            newPanel.button.gameObject.SetActive(!item.collected);
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
