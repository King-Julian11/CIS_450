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
