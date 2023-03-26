using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : Pickup
{
    [SerializeField] int healAmount = 20;
    protected override void OnPickup(Player player)
    {
        Health health = player.GetComponent<Health>();
        health.Heal(healAmount);
    }
}
