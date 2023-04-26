using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Default,
    HealthPotion,
    ManaPotion,
    Container,
    Consumable,
    Bomb,
    Arrow,
    SubWeapon,
}

public abstract class ItemComponent : MonoBehaviour
{
    public GameObject prefab;
    public ItemType type;
    [TextArea(15, 20)]
    public string description;

    public abstract void SpawnAllItemsInGrid(ItemComponent itemToAdd, Transform panelParent, Stack<GameObject> prefabsAdded);
}
