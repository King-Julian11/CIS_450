/* Julian Salgado
 * Jump.cs
 * Assignment 7
 * Manages jump input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Command
{
    MoveObject moveObject;

    Stack<Vector3> positionHistory;

    public Jump(MoveObject moveObject)
    {
        this.moveObject = moveObject;
        positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.Jump();
    }

    public void Undo()
    {
        if (positionHistory.Count != 0)
        {
            moveObject.gameObject.transform.position = positionHistory.Pop();
        }
    }
}
