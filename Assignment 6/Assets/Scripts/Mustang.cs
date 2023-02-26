/* Julian Salgado
 * Mustang.cs
 * Assignment 6
 * Class to create Mustang, subclass of car
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mustang : Car
{
    void Awake()
    {
        this.carBrand = "Mustang";
        this.speed = 70f;
    }

    void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
