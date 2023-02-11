/* Julian Salgado
 * Thunder.cs
 * Assignment 4
 * Updates materia with lightning element
 */

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
        return materia.getDamage() + 8;
    }

    public override string getDescription()
    {
        return "Thunder " + materia.getDescription();
    }

    public override int getSpeed()
    {
        return materia.getSpeed() + 14;
    }
}
