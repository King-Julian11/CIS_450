using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    Player moveObject;

    public MoveRight(Player moveObject)
    {
        this.moveObject = moveObject;
        //positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        //positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveRight();
    }
}
