using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FordCarFactory : CarFactory
{
    private GameObject fordPrefab;

    public override GameObject CreateCarPrefab(string brand)
    {
        if (brand.Equals("Bronco"))
        {
            fordPrefab = Resources.Load<GameObject>("Cube");
        }
        else if (brand.Equals("Mustang"))
        {
            fordPrefab = Resources.Load<GameObject>("Cube");
        }

        return fordPrefab;
    }

    public override GameObject AddCarBrand(GameObject prefab, string brand)
    {
        if (brand.Equals("Bronco"))
        {
            if (prefab.GetComponent<Bronco>() == null)
            {
                prefab.AddComponent<Bronco>();
            }
        }
        else if (brand.Equals("Mustang"))
        {
            if (prefab.GetComponent<Mustang>() == null)
            {
                prefab.AddComponent<Mustang>();
            }
        }

        return prefab;
    }
}
