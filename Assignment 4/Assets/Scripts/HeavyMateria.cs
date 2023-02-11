using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyMateria : Materia
{
    public HeavyMateria()
    {
        this.description = "Heavy Materia";
    }

    public override int getDamage()
    {
        return 12;
    }

    public override int getSpeed()
    {
        return 8;
    }
}
