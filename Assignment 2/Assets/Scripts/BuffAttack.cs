/* Julian Salgado
 * Assignment 2
 * BuffAttack.cs
 * BuffBehavior sub class that buffs attack power
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffAttack : BuffBehavior
{
    public override void Buff(GameObject o)
    {
        Debug.Log("Attack buffed!");
        o.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
