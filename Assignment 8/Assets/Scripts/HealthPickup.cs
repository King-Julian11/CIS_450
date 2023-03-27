/* Julian Salgado
 * HealthPickup.cs
 * Assignment 8
 * Subclass for health pickup
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    [SerializeField] float healAmount = 20f;
    protected override void OnPickup(Player player)
    {
        //player.health += healAmount;
        //Health health = player.GetComponent<Health>();
        //health.Heal(healAmount);
        player.Heal(healAmount);
    }
}
