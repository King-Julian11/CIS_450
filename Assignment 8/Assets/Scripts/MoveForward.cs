using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    Player moveObject;

    public MoveForward(Player moveObject)
    {
        this.moveObject = moveObject;
        //positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        //positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveForward();
    }
}
