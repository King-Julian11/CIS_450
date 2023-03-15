/* Julian Salgado
 * MoveForward.cs
 * Assignment 7
 * Manages move forward input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
    MoveObject moveObject;

    Stack<Vector3> positionHistory;

    public MoveForward(MoveObject moveObject)
    {
        this.moveObject = moveObject;
        positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveForward();
    }

    public void Undo()
    {
        if (positionHistory.Count != 0)
        {
            moveObject.gameObject.transform.position = positionHistory.Pop();
        }
    }
}