using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : Inventory
{
    public List<Inventory> inventoryComponents = new List<Inventory>();

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
        Debug.Log(GetItemType());
        if (!string.IsNullOrEmpty(description))
        {
            Debug.Log(description);
        }

        Debug.Log("-----Contents of " + GetItemType() + "-----");

        IterateWithIEnumerator(inventoryComponents);

        Debug.Log("---End of Contents of " + GetItemType() + "---");

    }

    private void IterateWithForEach(List<Inventory> inventoryComponents)
    {
        foreach (Inventory inventoryComponent in inventoryComponents)
        {
            inventoryComponent.GetDescription();
        }
    }

    private void IterateWithIEnumerator(IEnumerable<Inventory> inventoryComponents)
    {

        IEnumerator<Inventory> enumerator = inventoryComponents.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Inventory component = enumerator.Current;

            component.GetDescription();
        }

    }

    public override Inventory GetChildItem(int i)
    {
        return inventoryComponents[i];
    }
    public override void Add(Inventory inventoryComponent)
    {
        inventoryComponents.Add(inventoryComponent);
    }
    public override void Remove(Inventory inventoryComponent)
    {
        inventoryComponents.Remove(inventoryComponent);
    }
}
