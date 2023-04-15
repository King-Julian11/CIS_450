/* Julian Salgado
 * InputManager.cs
 * Assignment 11
 * Manages movement inputs
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController moveObject;
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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveForward.Execute();
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveLeft.Execute();
        }

        if (Input.GetKey(KeyCode.D))
        {
            moveRight.Execute();
        }

        if (Input.GetKey(KeyCode.S))
        {
            moveBack.Execute();
        }
    }
}
