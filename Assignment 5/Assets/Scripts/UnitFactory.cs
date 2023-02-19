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
        }
        else if (type.Equals("Brawler"))
        {
            unit = new Brawler();
        }
        else if (type.Equals("Mage"))
        {
            unit = new Mage();
        }

        return unit;
    }
}
