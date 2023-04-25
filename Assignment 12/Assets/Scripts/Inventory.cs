using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Inventory : MonoBehaviour
{
    public enum ItemType
    {
        Empty,
        HealthPotion,
        ManaPotion,
    }

    public ItemType itemType;
    public GameObject prefab;
    public string description;

    public abstract ItemType GetItemType();
    public abstract GameObject GetPrefab();
    public abstract void GetDescription();

    public virtual Inventory GetChildItem(int i)
    {
        throw new System.NotSupportedException("GetChildItem() is not supported for " + this.GetType().Name);
    }
    public virtual void Add(Inventory inventoryComponent)
    {
        throw new System.NotSupportedException("Add() is not supported for " + this.GetType().Name);
    }
    public virtual void Remove(Inventory inventoryComponent)
    {
        throw new System.NotSupportedException("Remove() is not supported for " + this.GetType().Name);
    }
    public virtual int GetAmount()
    {
        throw new System.NotSupportedException("GetAmount() is not supported for " + this.GetType().Name);
    }
}
