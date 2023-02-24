using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CarFactory
{
    public abstract GameObject CreateCarPrefab(string brand);

    public abstract GameObject AddCarBrand(GameObject prefab, string brand);
}
