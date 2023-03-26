using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth { get; private set; }

    public void Damage(int amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Kill();
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
    }

    public void Kill()
    {
        gameObject.SetActive(false);
    }
}
