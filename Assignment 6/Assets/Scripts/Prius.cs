/* Julian Salgado
 * Prius.cs
 * Assignment 6
 * Class to create Prius, subclass of car
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prius : Car
{
    void Awake()
    {
        this.carBrand = "Prius";
        this.speed = 60f;
    }

    void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
