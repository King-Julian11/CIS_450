/*
 * Julian Salgado
 * Simulator.cs
 * Assignment 1
 * Tests methods of each concrete class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simulator : MonoBehaviour
{
    public Slime slime;
    public Goblin goblin;
    public Wolf wolf;

    public List<Enemy> enemies;

    public List<AttackManager> attacks;

    // Start is called before the first frame update
    void Start()
    {
        slime = new Slime();
        goblin = new Goblin();
        wolf = new Wolf();

        enemies = new List<Enemy>(5);

        enemies.Add(slime);
        enemies.Add(goblin);
        enemies.Add(slime);
        enemies.Add(goblin);
        enemies.Add(wolf);

        attacks = new List<AttackManager>(5);

        attacks.Add(slime);
        attacks.Add(goblin);
        attacks.Add(slime);
        attacks.Add(goblin);
        attacks.Add(wolf);
    }

    // Update is called once per frame
    void Update()
    {
        //slime.attack();
        //slime.damage();
        //slime.health();

        //goblin.attack();
        //goblin.damage();
        //goblin.health();

        //wolf.attack();
        //wolf.damage();
        //wolf.health();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Enemy e in enemies){
                e.damage();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (AttackManager n in attacks)
            {
                n.attack();
            }
        }
    }
}
