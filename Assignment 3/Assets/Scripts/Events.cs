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
        return 30f;
    }
}

public class JumpMed : Events
{
    public override float GetJumpForce()
    {
        return 60f;
    }
}

public class JumpHigh : Events
{
    public override float GetJumpForce()
    {
        return 90f;
    }
}
