using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerComposite : ItemComponent
{
    public List<ItemComponent> components = new List<ItemComponent>();

    private void Awake()
    {
        type = ItemType.Container;
    }

    public override void SpawnAllItemsInGrid(ItemComponent itemToAdd, Transform panelParent, Stack<GameObject> prefabsAdded)
    {
        GameObject spawnedButton = Instantiate(itemToAdd.prefab, panelParent);
        prefabsAdded.Push(spawnedButton);

        foreach (ItemComponent itemComponent in components)
        {
            itemComponent.SpawnAllItemsInGrid(itemComponent, panelParent, prefabsAdded);
        }
    }
}
