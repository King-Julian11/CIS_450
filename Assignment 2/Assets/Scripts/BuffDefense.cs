/* Julian Salgado
 * Assignment 2
 * BuffDefense.cs
 * BuffBehavior sub class that buffs defense
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffDefense : BuffBehavior
{
    public override void Buff(GameObject o)
    {
        Debug.Log("Defense buffed!");
        o.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
