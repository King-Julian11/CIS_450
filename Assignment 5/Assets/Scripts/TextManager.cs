using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    UnitFactory factory;
    UnitSpawner spawner;
    Defender unit;

    void Start()
    {
        factory = new UnitFactory();
        spawner = new UnitSpawner(factory);
    }

    public void SpawnUnit(string type)
    {
        unit = spawner.SpawnUnit(type);
        DisplayText();
    }

    public void DisplayText()
    {
        gameObject.GetComponent<Text>().text = unit.ToString();
    }
}
