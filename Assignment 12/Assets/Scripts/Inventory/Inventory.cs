using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InventorySlot> inventory = new List<InventorySlot>();

    public void AddItem(ItemComponent itemToAdd, int amountToAdd)
    {
        bool inventoryHasItem = false;

        foreach (InventorySlot inventorySlot in inventory)
        {
            if (inventorySlot.item.Equals(itemToAdd))
            {
                inventorySlot.AddAmount(amountToAdd);
                inventoryHasItem = true;
                break;
            }
        }

        if (!inventoryHasItem)
        {
            inventory.Add(new InventorySlot(itemToAdd, amountToAdd));
        }

    }
}
