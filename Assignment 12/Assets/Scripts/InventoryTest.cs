using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryTest : MonoBehaviour
{
    public Container inventory;

    // Use this for initialization
    void Start()
    {
        inventory.GetDescription();
    }
}
