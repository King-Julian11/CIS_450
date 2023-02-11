/* Julian Salgado
 * LightMateria.cs
 * Assignment 4
 * Class for light materia, a weaker damage but quicker casting materia
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMateria : Materia
{
    public LightMateria()
    {
        this.description = "Light Materia";
    }

    public override int getDamage()
    {
        return 8;
    }

    public override int getSpeed()
    {
        return 12;
    }
}
