/* Julian Salgado
 * Fire.cs
 * Assignment 4
 * Updates materia with fire element
 */

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
        return materia.getDamage() + 10;
    }

    public override string getDescription()
    {
        return "Fire " + materia.getDescription();
    }

    public override int getSpeed()
    {
        return materia.getSpeed() + 10;
    }
}
