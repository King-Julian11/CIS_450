/* Julian Salgado
 * ComsumableLeaf.cs
 * Assignment 12
 * Mananges features of consumable items
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsumableLeaf : ItemLeaf
{
    public int healthRestoreAmount;
    public int manaRestoreAmount;

    private void Awake()
    {
        type = ItemType.Consumable;
    }
}
