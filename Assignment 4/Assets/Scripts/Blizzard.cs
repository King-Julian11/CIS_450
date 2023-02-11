using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blizzard : ElementsDecorator
{
    public Materia materia;

    public Blizzard(Materia materia)
    {
        this.materia = materia;
    }

    public override int getDamage()
    {
        return materia.getDamage() + 14;
    }

    public override string getDescription()
    {
        return "Blizzard" + materia.getDescription();
    }

    public override int getSpeed()
    {
        return materia.getSpeed() + 8;
    }
}
