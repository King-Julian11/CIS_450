/* Julian Salgado
 * Assignment 2
 * Swordsman.cs
 * Swordsman sub class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordsman : Character
{
    // Start is called before the first frame update
    public override void Start()
    {
        attack = 14;
        speed = 8;
        defense = 10;
    }
}
