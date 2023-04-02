/* Julian Salgado
 * PlayerController.cs
 * Assignment 9
 * Manages player movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;

    public void MoveForward()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    public void MoveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    public void MoveBack()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);
    }
}
