using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bronco : Car
{
    void Awake()
    {
        this.carBrand = "Bronco";
        this.speed = 50f;
    }

    void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.gray;
    }
}
