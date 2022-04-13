using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public IntData cash;
    public InventoryLayoutBehaviour layoutPrefab;
    public List<InventoryItem> inventoryItemList;

    public void ConstructInventoryLayout(Transform obj)
    {
        foreach (var item in inventoryItemList)
        {
            var newItem = Instantiate(layoutPrefab, obj);
            newItem.image.sprite = item.art2D;
            newItem.label.text = item.name;
            newItem.buttonLabel.text = "Buy $" + item.cashValue; 
            
            if (item.cashValue >= cash.value)
            {
                newItem.button.interactable = false;
            }
        }
    }
}