/* Julian Salgado
 * Assignment 2
 * Brawler.cs
 * Brawler sub class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brawler : Character
{
    // Start is called before the first frame update
    public override void Start()
    {
        attack = 10;
        speed = 14;
        defense = 9;
    }
}
