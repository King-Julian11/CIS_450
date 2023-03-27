/* Julian Salgado
 * InputManager.cs
 * Assignment 8
 * Manages movement inputs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public Player moveObject;
    private MoveLeft moveLeft;
    private MoveRight moveRight;
    private MoveForward moveForward;
    private MoveBack moveBack;

    void Awake()
    {
        moveLeft = new MoveLeft(moveObject);
        moveRight = new MoveRight(moveObject);
        moveForward = new MoveForward(moveObject);
        moveBack = new MoveBack(moveObject);
        //jump = new Jump(moveObject);
        //commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.Execute();
            //commandHistory.Push(moveForward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft.Execute();
            //commandHistory.Push(moveLeft);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight.Execute();
            //commandHistory.Push(moveRight);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveBack.Execute();
            //commandHistory.Push(moveBackward);
        }
    }
}
