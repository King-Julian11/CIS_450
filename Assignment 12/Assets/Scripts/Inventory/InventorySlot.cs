/* Julian Salgado
 * InventorySlot.cs
 * Assignment 12
 * Mananges features of inventory slots
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot
{
    public ItemComponent item;
    public int amount;

    public InventorySlot(ItemComponent item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }

    public void AddAmount(int amount)
    {
        this.amount += amount;
    }
}
