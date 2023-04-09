/* Julian Salgado
 * Rush.cs
 * Assignment 10
 * Causes GameObjects to rush out
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rush : MonoBehaviour
{
    public float upForce = .1f;
    public float sideForce = 1f;

    private void Start()
    {
        //generate random force
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce / 2f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        //add random force to the RigidBody
        GetComponent<Rigidbody>().velocity = force;
    }
}
