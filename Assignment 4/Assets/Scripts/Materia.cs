/* Julian Salgado
 * Materia.cs
 * Assignment 4
 * Abstract class for materia
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Materia
{
    public string description = "Unknown";

    public virtual string getDescription()
    {
        return description;
    }

    public abstract int getDamage();

    public abstract int getSpeed();
}
