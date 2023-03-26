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

    private void Reset()
    {
        Collider _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        if (player = null)
            return;

        OnPickup(player);

        Disable();
    }

    protected virtual void Disable()
    {
        gameObject.SetActive(false);
    }
}
