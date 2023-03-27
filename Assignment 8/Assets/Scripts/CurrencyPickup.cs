/* Julian Salgado
 * CurrencyPickup.cs
 * Assignment 8
 * Subclass for currency pickup
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyPickup : Pickup
{
    [SerializeField] float value = 1;

    protected override void OnPickup(Player player)
    {
        //player.coinCount += value;
        player.AddCoin(value);
    }
}
