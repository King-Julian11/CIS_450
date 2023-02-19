using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSpawner : MonoBehaviour
{
    public UnitFactory factory;
    public Defender unit;

    public UnitSpawner(UnitFactory factory)
    {
        this.factory = factory;
    }

    public Defender SpawnUnit(string type)
    {
        unit = factory.CreateUnit(type);

        unit.Attack();
        unit.Move();

        return unit;
    }
}
