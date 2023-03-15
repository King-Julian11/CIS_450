/* Julian Salgado
 * MoveForward.cs
 * Assignment 7
 * Manages movement input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public float jumpForce;
    public ForceMode jumpForceMode;
    public float gravityModifier;
    public bool grounded;

    public void Start()
    {
        speed = 10f;
        rb = GetComponent<Rigidbody>();
        jumpForce = 10f;

        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    public Vector3 GetCurrentPosition()
    {
        return gameObject.transform.position;
    }

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

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
        jumpForceMode = ForceMode.Impulse;
        //grounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
