/* Julian Salgado
 * Mage.cs
 * Assignment 5
 * Class for mage units
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Defender
{
    public Mage()
    {
        this.type = "Mage";
        this.weapon = "Staff";
        this.damage = 11;
        this.speed = 6f;
    }
}
