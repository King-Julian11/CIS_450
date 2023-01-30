/* Julian Salgado
 * Assignment 2
 * BuffSpeed.cs
 * BuffBehavior sub class that buffs speed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffSpeed : BuffBehavior
{
    public override void Buff(GameObject o)
    {
        Debug.Log("Speed buffed!");
        o.gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
