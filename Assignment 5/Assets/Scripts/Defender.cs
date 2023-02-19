using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    protected string type;
    protected string weapon;
    protected float damage;
    protected float speed;

    public void Attack()
    {
        Debug.Log(this.type + " uses " + this.weapon + " to deal " + this.damage + " damage.");
    }

    public void Move()
    {
        Debug.Log(this.type + " moves at " + this.speed + " speed.");
    }

    public override string ToString()
    {
        return "Unit: " + this.type + "\nWeapon: " + this.weapon;
    }
}
