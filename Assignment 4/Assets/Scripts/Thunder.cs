using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : ElementsDecorator
{
    public Materia materia;

    public Thunder(Materia materia)
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
