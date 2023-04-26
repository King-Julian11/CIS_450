using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    public Transform panelParent;

    public Inventory inventory;

    public Stack<GameObject> prefabsAdded = new Stack<GameObject>();

    public void SpawnAllInventoryItems()
    {

        foreach (InventorySlot inventorySlot in inventory.inventory)
        {
            ItemComponent itemToAdd = inventorySlot.item;
            if (itemToAdd != null)
            {
                itemToAdd.SpawnAllItemsInGrid(itemToAdd, panelParent, prefabsAdded);
            }
        }

    }

    public void Remove()
    {
        if (prefabsAdded.Count > 0)
        {
            GameObject buttonToRemove = prefabsAdded.Pop();
            Destroy(buttonToRemove);
        }
    }
}
