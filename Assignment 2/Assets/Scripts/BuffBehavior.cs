/* Julian Salgado
 * Assignment 2
 * BuffBehavior.cs
 * Abstract class for buff behavior
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuffBehavior : ScriptableObject
{

    public abstract void Buff(GameObject o);

}
