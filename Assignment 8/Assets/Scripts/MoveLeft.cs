/* Julian Salgado
 * MoveLeft.cs
 * Assignment 8
 * Manages left movement input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    Player moveObject;

    public MoveLeft(Player moveObject)
    {
        this.moveObject = moveObject;
        //positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        //positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveLeft();
    }
}
