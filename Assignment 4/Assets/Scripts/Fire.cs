using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : ElementsDecorator
{
    public Materia materia;

    public Fire(Materia materia)
    {
        this.materia = materia;
    }

    public override int getDamage()
    {
        return materia.getDamage();
    }

    public override string getDescription()
    {
        return materia.getDescription();
    }
}
