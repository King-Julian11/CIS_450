/* Julian Salgado
 * Pickup.cs
 * Assignment 8
 * Superclass for pickup
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    protected abstract void OnPickup(Player player);

    Collider collider = null;

    private void Awake()
    {
        collider = GetComponent<Collider>();
    }


    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        OnPickup(player);
    }
}
