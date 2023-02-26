/* Julian Salgado
 * Car.cs
 * Assignment 6
 * Class to create car
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public string carBrand;
    public float speed;

    void Drive()
    {
        Debug.Log(this.carBrand + " travels at " + this.speed + " miles per hour.");
    }

    public override string ToString()
    {
        return "Car Brand: " + this.carBrand;
    }
}
