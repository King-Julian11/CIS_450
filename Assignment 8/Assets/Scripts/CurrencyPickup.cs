using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : Pickup
{
    [SerializeField] int value = 1;

    protected override void OnPickup(Player player)
    {
        player.AddCoin(value);
    }
}
