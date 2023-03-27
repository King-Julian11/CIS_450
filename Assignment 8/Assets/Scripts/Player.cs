/* Julian Salgado
 * Player.cs
 * Assignment 8
 * Manages player character
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public float coinCount;

    public float speed = 10f;
    public float health;

    void Start()
    {
        coinCount = 0;
        health = 100f;
    }

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    public void MoveBack()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }

    public void AddCoin(float numCoins)
    {
        coinCount += numCoins;
    }

    public void Heal(float amount)
    {
        health += amount;
    }
}
