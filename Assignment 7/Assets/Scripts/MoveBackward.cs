/* Julian Salgado
 * MoveBackward.cs
 * Assignment 7
 * Manages move backward input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : Command
{
    MoveObject moveObject;

    Stack<Vector3> positionHistory;

    public MoveBackward(MoveObject moveObject)
    {
        this.moveObject = moveObject;
        positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveBack();
    }

    public void Undo()
    {
        if (positionHistory.Count != 0)
        {
            moveObject.gameObject.transform.position = positionHistory.Pop();
        }
    }
}
