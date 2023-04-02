/* Julian Salgado
 * MoveForwards.cs
 * Assignment 9
 * Manages moving forwards
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    PlayerController moveObject;

    public MoveForward(PlayerController moveObject)
    {
        this.moveObject = moveObject;
    }

    public void Execute()
    {
        moveObject.MoveForward();
    }
}
