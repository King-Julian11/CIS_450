/* Julian Salgado
 * ToyotaCarFactory.cs
 * Assignment 6
 * Factory to create Toyota brand cars, subclass of CarFactory
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyotaCarFactory : CarFactory
{
    private GameObject toyotaPrefab;

    public override GameObject CreateCarPrefab(string brand)
    {
        if (brand.Equals("Prius"))
        {
            toyotaPrefab = Resources.Load<GameObject>("Cylinder");
        }
        else if (brand.Equals("Mirai"))
        {
            toyotaPrefab = Resources.Load<GameObject>("Sphere");
        }

        return toyotaPrefab;
    }

    public override GameObject AddCarBrand(GameObject prefab, string brand)
    {
        if (brand.Equals("Prius"))
        {
            if (prefab.GetComponent<Prius>() == null)
            {
                prefab.AddComponent<Prius>();
            }
        }
        else if (brand.Equals("Mirai"))
        {
            if (prefab.GetComponent<Mirai>() == null)
            {
                prefab.AddComponent<Mirai>();
            }
        }

        return toyotaPrefab;
    }
}
