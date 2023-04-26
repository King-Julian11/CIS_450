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
