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
}
