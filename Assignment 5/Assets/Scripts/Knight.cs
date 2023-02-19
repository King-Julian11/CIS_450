using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Defender
{
    public Knight()
    {
        this.type = "Knight";
        this.weapon = "Sword";
        this.damage = 10;
        this.speed = 8f;
    }
}
