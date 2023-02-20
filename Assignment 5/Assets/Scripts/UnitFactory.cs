/* Julian Salgado
 * UnityFactory.cs
 * Assignment 5
 * Factroy class for defender units
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitFactory
{
    public Defender CreateUnit(string type)
    {
        Defender unit = null;

        if (type.Equals("Knight"))
        {
            unit = new Knight();
            GameObject.FindGameObjectWithTag("Unit").GetComponent<MeshRenderer>().material.color
                = Color.blue;
        }
        else if (type.Equals("Brawler"))
        {
            unit = new Brawler();
            GameObject.FindGameObjectWithTag("Unit").GetComponent<MeshRenderer>().material.color
                = Color.red;
        }
        else if (type.Equals("Mage"))
        {
            unit = new Mage();
            GameObject.FindGameObjectWithTag("Unit").GetComponent<MeshRenderer>().material.color
                = Color.cyan;
        }

        return unit;
    }
}
