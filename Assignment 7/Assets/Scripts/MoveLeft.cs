/* Julian Salgado
 * MoveLeft.cs
 * Assignment 7
 * Manages move left input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    MoveObject moveObject;

    Stack<Vector3> positionHistory;

    public MoveLeft(MoveObject moveObject)
    {
        this.moveObject = moveObject;
        positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveLeft();
    }

    public void Undo()
    {
        if (positionHistory.Count != 0)
        {
            moveObject.gameObject.transform.position = positionHistory.Pop();
        }
    }
}
