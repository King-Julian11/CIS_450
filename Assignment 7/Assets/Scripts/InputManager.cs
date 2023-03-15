/* Julian Salgado
 * InputManager.cs
 * Assignment 7
 * Receiver class that manages inputs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public MoveObject moveObject;
    private Command moveLeft;
    private Command moveRight;
    private Command moveForward;
    private Command moveBackward;
    private Command jump;

    public Stack<Command> commandHistory;

    void Awake()
    {
        moveLeft = new MoveLeft(moveObject);
        moveRight = new MoveRight(moveObject);
        moveForward = new MoveForward(moveObject);
        moveBackward = new MoveBackward(moveObject);
        jump = new Jump(moveObject);
        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.Execute();
            commandHistory.Push(moveForward);
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft.Execute();
            commandHistory.Push(moveLeft);
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight.Execute();
            commandHistory.Push(moveRight);
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveBackward.Execute();
            commandHistory.Push(moveBackward);
        }

        if (Input.GetKey(KeyCode.Space) && moveObject.grounded)
        {
            jump.Execute();
            commandHistory.Push(jump);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if (commandHistory.Count != 0)
            {
                Command lastCommand = commandHistory.Pop();

                lastCommand.Undo();
            }
        }
    }
}
