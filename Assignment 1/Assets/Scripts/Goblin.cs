/*
 * Julian Salgado
 * Goblin.cs
 * Assignment 1
 * Create instance of goblin enemy
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy, AttackManager, HealthManager
{

    public long healthPts;

    public long damagePts;

    public void attack()
    {
        Debug.Log("The goblin deals " + damagePts + " damage.");
    }

    public override void damage()
    {
        Debug.Log("Goblin damage multiplier chance.");
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
