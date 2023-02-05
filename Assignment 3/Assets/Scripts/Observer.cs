/* Julian Salgado
 * Observer.cs
 * Assignment 3
 * Observer script that manages observers' response to subject
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer
{
    public abstract void OnNotify();
}

public class Box : Observer
{
    GameObject box;

    Events boxEvents;

    public Box(GameObject box, Events boxEvents)
    {
        this.box = box;
        this.boxEvents = boxEvents;
    }

    public override void OnNotify()
    {
        Jump(boxEvents.GetJumpForce());
    }

    void Jump(float jumpForce)
    {
        if (Input.GetButtonDown("Jump"))
        {
            box.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
