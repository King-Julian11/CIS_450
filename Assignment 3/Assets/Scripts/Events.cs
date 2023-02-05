/* Julian Salgado
 * Event.cs
 * Assignment 3
 * Event manager script that determines the behavior of the observers.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Events
{
    public abstract float GetJumpForce();
}

public class JumpLow : Events
{
    public override float GetJumpForce()
    {
        return 150f;
    }
}

public class JumpMed : Events
{
    public override float GetJumpForce()
    {
        return 300f;
    }
}

public class JumpHigh : Events
{
    public override float GetJumpForce()
    {
        return 450f;
    }
}
