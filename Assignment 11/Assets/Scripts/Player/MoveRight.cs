/* Julian Salgado
 * MoveBack.cs
 * Assignment 11
 * Manages moving right
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    PlayerController moveObject;

    public MoveRight(PlayerController moveObject)
    {
        this.moveObject = moveObject;
    }

    public void Execute()
    {
        moveObject.MoveRight();
    }
}
