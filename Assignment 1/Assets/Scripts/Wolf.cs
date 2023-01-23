/*
 * Julian Salgado
 * Wolf.cs
 * Assignment 1
 * Create instance of wolf enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Enemy, AttackManager, HealthManager
{
    public long healthPts;

    public long damagePts;

    public void attack()
    {
        Debug.Log("The wolf deals " + damagePts + " damage.");
    }

    public override void damage()
    {
        Debug.Log("Wolf damage multiplier chance.");
    }

    public void health()
    {
        Debug.Log("The slime has " + healthPts + " health points");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
