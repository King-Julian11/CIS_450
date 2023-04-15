/* Julian Salgado
 * MoveLeft.cs
 * Assignment 11
 * Manages moving left
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    PlayerController moveObject;

    public MoveLeft(PlayerController moveObject)
    {
        this.moveObject = moveObject;
    }

    public void Execute()
    {
        moveObject.MoveLeft();
    }
}
