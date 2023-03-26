using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public event Action<int> OnCoinsCollected = delegate { };

    public int coinCount { get; private set; } = 0;

    public float speed = 10f;

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

    public void AddCoin(int numCoins)
    {
        coinCount += numCoins;
        OnCoinsCollected.Invoke(coinCount);
    }
}
