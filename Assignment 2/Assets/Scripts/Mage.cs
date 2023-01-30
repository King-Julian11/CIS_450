/* Julian Salgado
 * Assignment 2
 * Mage.cs
 * Mage sub class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Character
{
    // Start is called before the first frame update
    public override void Start()
    {
        attack = 7;
        speed = 6;
        defense = 9;
    }
}
