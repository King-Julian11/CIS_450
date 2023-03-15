/* Julian Salgado
 * MoveRight.cs
 * Assignment 7
 * Manages move right input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
    MoveObject moveObject;

    Stack<Vector3> positionHistory;

    public MoveRight(MoveObject moveObject)
    {
        this.moveObject = moveObject;
        positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveRight();
    }

    public void Undo()
    {
        if (positionHistory.Count != 0)
        {
            moveObject.gameObject.transform.position = positionHistory.Pop();
        }
    }
}
