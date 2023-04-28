/* Julian Salgado
 * ItemLeaf.cs
 * Assignment 12
 * Mananges features of items
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLeaf : ItemComponent
{
    private void Awake()
    {
        type = ItemType.Default;
    }

    public override void SpawnAllItemsInGrid(ItemComponent itemToAdd, Transform panelParent, Stack<GameObject> prefabsAdded)
    {
        GameObject spawnedButton = Instantiate(itemToAdd.prefab, panelParent);
        prefabsAdded.Push(spawnedButton);
    }
}
