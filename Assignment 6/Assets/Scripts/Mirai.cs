using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirai : Car
{
    void Awake()
    {
        this.carBrand = "Mirai";
        this.speed = 60f;
    }

    void OnEnable()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
