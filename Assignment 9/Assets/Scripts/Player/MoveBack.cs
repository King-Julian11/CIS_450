/* Julian Salgado
 * MoveBack.cs
 * Assignment 9
 * Manages moving back
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    PlayerController moveObject;

    public MoveBack(PlayerController moveObject)
    {
        this.moveObject = moveObject;
    }

    public void Execute()
    {
        moveObject.MoveBack();
    }
}
