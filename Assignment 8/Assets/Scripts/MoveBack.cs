using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    Player moveObject;

    public MoveBack(Player moveObject)
    {
        this.moveObject = moveObject;
        //positionHistory = new Stack<Vector3>();
    }

    public void Execute()
    {
        //positionHistory.Push(moveObject.GetCurrentPosition());

        moveObject.MoveBack();
    }
}
