using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : Inventory
{
    public int amount;

    public override int GetAmount()
    {
        return amount;
    }

    public override ItemType GetItemType()
    {
        return itemType;
    }

    public override GameObject GetPrefab()
    {
        return prefab;
    }

    public override void GetDescription()
    {
        Debug.Log(GetAmount() + " " + GetItemType());

        if (!string.IsNullOrEmpty(description))
        {
            Debug.Log(description);
        }
    }
}
