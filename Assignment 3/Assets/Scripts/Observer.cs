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
        if (box.transform.position.y < 0.55f)
        {
            box.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }
    }
}
