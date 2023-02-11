/* Julian Salgado
 * ElementsDecorator.cs
 * Assignment 4
 * Abstract class that serves as the decorator for materia elements
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ElementsDecorator : Materia
{
    public abstract override string getDescription();
}
