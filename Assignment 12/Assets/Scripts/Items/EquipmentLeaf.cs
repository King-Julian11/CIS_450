using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentLeaf : ItemLeaf
{
    public float atkBonus;
    public float defBonus;

    private void Awake()
    {
        type = ItemType.SubWeapon;
    }
}
