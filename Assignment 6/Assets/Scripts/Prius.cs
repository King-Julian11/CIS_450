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
