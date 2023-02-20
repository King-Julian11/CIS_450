/* Julian Salgado
 * Brawler.cs
 * Assignment 5
 * Class for brawler units
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brawler : Defender
{
    public Brawler()
    {
        this.type = "Brawler";
        this.weapon = "Gauntlets";
        this.damage = 14;
        this.speed = 7f;
    }
}
