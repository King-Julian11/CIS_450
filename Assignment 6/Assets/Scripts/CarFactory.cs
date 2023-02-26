/* Julian Salgado
 * CarFactory.cs
 * Assignment 6
 * Factory to create cars
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CarFactory
{
    public abstract GameObject CreateCarPrefab(string brand);

    public abstract GameObject AddCarBrand(GameObject prefab, string brand);
}
