using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public ItemComponent itemToPickup;
    public Inventory inventory;
    public int amount;

    private void Start()
    {
        //Set the sprite of this gameObject to the sprite of the itemToPickup
        //gameObject.GetComponent<Image>().sprite = itemToPickup.prefab.GetComponent<Image>().sprite;

        //Set the text of this gameObject to the amount of the item on this script
        //gameObject.GetComponentInChildren<Text>().text = amount.ToString();
    }

    public void AddItem()
    {
        inventory.AddItem(itemToPickup, amount);
    }
}
